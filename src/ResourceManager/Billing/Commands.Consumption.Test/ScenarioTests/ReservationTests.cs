﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Consumption.Test.ScenarioTests.ScenarioTest;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Consumption.Test.ScenarioTests
{
    public class ReservationTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public ReservationTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesMonthlyWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationSummariesMonthlyWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesMonthlyWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationSummariesMonthlyWithOrderIdAndId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesDailyWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationSummariesDailyWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationSummariesDailyWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationSummariesDailyWithOrderIdAndId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationDetailsWithOrderId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationDetailsWithOrderId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListReservationDetailsWithOrderIdAndId()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListReservationDetailsWithOrderIdAndId");
        }
    }
}
