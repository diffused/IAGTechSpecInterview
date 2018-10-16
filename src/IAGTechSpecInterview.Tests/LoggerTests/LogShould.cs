﻿using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IAGTechSpecInterview.Tests.LoggerTests
{
    public class LogShould
    {
        /// <summary>
        /// Please refactor the sut FourWallsInterview.Logger and verify the 
        /// Log method is being called correctly
        /// </summary>
        [Fact]
        public void Call_Log_with_message()
        {
            var mockMessageLogger = new Mock<IMessageLogger>();
            var sut = new Logger(mockMessageLogger.Object);

            sut.Log("appears on console");
            mockMessageLogger.Verify(a => a.Log(It.IsAny<string>()));
        }
    }
}
