const { exec } = require('child_process');

function runTestsWithRetry(attempt = 0, maxAttempts = 5) {
  console.log(`🟡 Running test attempt ${attempt + 1}/${maxAttempts}`);

  exec('dotnet test --no-build --filter TestCategory="IncludeFailures" --logger:"junit;LogFilePath=test-output.xml"', (error, stdout, stderr) => {
    if (!error) {
      console.log('Tests passed successfully.');
      process.exit(0);
    }

    console.log(stderr);
    console.log('Tests failed.');

    if (attempt + 1 < maxAttempts) {
      console.log('🟡 Retrying... ');
      runTestsWithRetry(attempt + 1, maxAttempts);
    } else {
      console.log(`💥 Tests failed after ${maxAttempts} attempts.`);
      process.exit(1);
    }
  });
}

runTestsWithRetry();