﻿using System.ServiceModel;

namespace ConcurrentServices.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                     ConcurrencyMode = ConcurrencyMode.Single,
                     UseSynchronizationContext = true)]
    public class Singleton_Single_Service : BaseService
    {
    }
}
