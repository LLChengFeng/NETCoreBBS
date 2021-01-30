using NETCoreBBS.EventBus.Abstractions;
using NETCoreBBS.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NETCoreBBS.EventBus.MemoryQueue
{
    public class InMemoryEventBus : IEventBus
    {
        public Task PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void SubscribeDynamic<TH>(string eventName) where TH : IIntegrationEventHandler
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeDynamic<TH>(string eventName) where TH : IIntegrationEventHandler
        {
            throw new NotImplementedException();
        }
    }
}
