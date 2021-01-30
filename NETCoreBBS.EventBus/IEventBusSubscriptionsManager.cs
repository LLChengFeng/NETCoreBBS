using NETCoreBBS.EventBus.Abstractions;
using NETCoreBBS.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreBBS.EventBus
{
    public interface IEventBusSubscriptionsManager
    {
        bool IsEmpty { get; }

        event EventHandler<string> OnEventRemoved;

        void AddDynamicSubscription<TH>(string eventName) where TH : IDynamicIntegrationEventHandler;
        void AddSubscription<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;
        void Clear();
        SubscriptionInfo DoFindSubscriptionToRemove(string eventName, Type handlerType);
        void DoRemoveHandler(string eventName, SubscriptionInfo subsToRemove);
        Type GetEeventTypeName(string eventName);
        string GetEventKey<T>();
        IEnumerable<SubscriptionInfo> GetHandlerForEvent(string eventName);
        IEnumerable<SubscriptionInfo> GetHandlerForEvent<T>() where T : IntegrationEvent;
        bool HasSubscriptionForEvent(string eventName);
        bool HasSubscriptionForEvent<T>() where T : IntegrationEvent;
        void RaiseOnEventRemoved(string eventName);
        void RemoveDynamicSubscripttion<TH>(string eventName) where TH : IDynamicIntegrationEventHandler;
        void RemoveSubscription<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;
    }
}
