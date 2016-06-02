﻿namespace ScienceAlert.Game
{
    public interface IGameFactory
    {
        IModuleScienceExperiment Create(ModuleScienceExperiment mse);
        IVessel Create(Vessel vessel);
        IPart Create(Part part);
        IScienceSubject Create(ScienceSubject subject);
        ICelestialBody Create(CelestialBody body);
        IScienceLab Create(ModuleScienceLab lab);
        IUrlConfig Create(UrlDir.UrlConfig config);
    }
}
