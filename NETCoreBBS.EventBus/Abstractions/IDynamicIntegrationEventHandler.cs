using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreBBS.EventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler:IIntegrationEventHandler
    {
        Task HandleAsync(dynamic eventData);
    }
}
