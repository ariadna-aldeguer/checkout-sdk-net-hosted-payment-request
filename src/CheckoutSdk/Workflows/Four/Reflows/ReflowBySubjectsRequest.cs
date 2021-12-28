﻿using System.Collections.Generic;

namespace Checkout.Workflows.Four.Reflows
{
    public class ReflowBySubjectsRequest : ReflowRequest
    {
        public IList<string> Subjects { get; }

        public ReflowBySubjectsRequest(IList<string> subjects, IList<string> workflows) : base(workflows)
        {
            this.Subjects = subjects;
        }
    }
}