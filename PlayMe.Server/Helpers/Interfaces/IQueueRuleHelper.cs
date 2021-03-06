﻿using System.Collections.Generic;
using PlayMe.Common.Model;

namespace PlayMe.Server.Helpers.Interfaces
{
    public interface IQueueRuleHelper
    {
        IEnumerable<string> CannotQueueTrack(Track track, string user);
    }
}
