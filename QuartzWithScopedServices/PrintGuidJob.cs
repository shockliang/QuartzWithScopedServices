using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;

namespace QuartzWithScopedServices
{
    public class PrintGuidJob : IJob
    {
        private readonly ILogger<PrintGuidJob> _logger;
        private readonly Guid _guid;

        public PrintGuidJob(ILogger<PrintGuidJob> logger)
        {
            _logger = logger;
            _guid = Guid.NewGuid();
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("The job GUID is: " + _guid);
            return Task.CompletedTask;
        }
    }
}