﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("TumblingWindowTrigger")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSTumblingWindowTrigger : PSSinglePipelineTrigger
    {
        public PSTumblingWindowTrigger()
        {
            CustomInit();
        }

        partial void CustomInit();

        [JsonProperty(PropertyName = "typeProperties.frequency")]
        public TumblingWindowFrequency Frequency { get; set; }

        [JsonProperty(PropertyName = "typeProperties.interval")]
        public int Interval { get; set; }

        [JsonProperty(PropertyName = "typeProperties.startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty(PropertyName = "typeProperties.endTime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty(PropertyName = "typeProperties.delay")]
        public object Delay { get; set; }

        [JsonProperty(PropertyName = "typeProperties.maxConcurrency")]
        public int MaxConcurrency { get; set; }

        [JsonProperty(PropertyName = "typeProperties.retryPolicy")]
        public RetryPolicy RetryPolicy { get; set; }

        [JsonProperty(PropertyName = "typeProperties.dependsOn")]
        public IList<DependencyReference> DependsOn { get; set; }

        public override Trigger ToSdkObject()
        {
            var trigger = new TumblingWindowTrigger(this.Pipeline, this.Frequency, this.Interval, this.StartTime, this.MaxConcurrency);
            trigger.EndTime = this.EndTime;
            trigger.Delay = this.Delay;
            trigger.RetryPolicy = this.RetryPolicy;
            this.DependsOn?.ForEach(item => trigger.DependsOn.Add(item));
            SetProperties(trigger);
            return trigger;
        }
    }
}
