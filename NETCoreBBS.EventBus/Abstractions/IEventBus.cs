using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NETCoreBBS.EventBus.Events;

namespace NETCoreBBS.EventBus.Abstractions
{
    public interface IEventBus
    {
        Task PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default);

        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        void Unsubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        void SubscribeDynamic<TH>(string eventName) where TH : IIntegrationEventHandler;

        void UnsubscribeDynamic<TH>(string eventName) where TH : IIntegrationEventHandler;
    }
}
