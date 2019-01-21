﻿using ECS.Systems.Navigation;

namespace ECS.Features
{
    public sealed class NavigationFeature : Feature
    {
        public NavigationFeature(Contexts contexts, ServiceContainer serviceContainer)
        {
            Add(new OnNavigableEntityDoAddAgent(contexts, serviceContainer.Get<INavigationService>())); 
            Add(new OnNavigationInputDoSetAgentDestination(contexts, serviceContainer.Get<INavigationService>())); 
            Add(new NavigationTick(contexts, serviceContainer.Get<INavigationService>()));
            Add(new SyncAgentPosition(contexts, serviceContainer.Get<INavigationService>()));   
        }
    }
}