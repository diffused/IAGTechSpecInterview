# IAG Tech Spec Interview

Please fork and send this test back to us.

## Overview

This is a short refactoring exercise.

The class IAGTechSpecInterview.Logger violates the Open Close Principle.

Refactor this class so that message logging types are passed in when constructing IAGTechSpecInterview.Logger, and write a test to ensure IAGTechSpecInterview.Logger.Log is being called with a single string parameter.

## Notes

You don't need to install an IOC package.

We are just looking to see how you refactor and write tests

Xunit and MOQ have already been installed in the solution. If you have a different preferred mocking or fakes framework, then go ahead and use that :)