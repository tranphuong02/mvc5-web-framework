﻿using Framework.DI.Contracts.Interfaces;

namespace Transverse.Interfaces.Business
{
    public interface ITestBusiness : IDependency
    {
        void ExecuteTest();
    }
}