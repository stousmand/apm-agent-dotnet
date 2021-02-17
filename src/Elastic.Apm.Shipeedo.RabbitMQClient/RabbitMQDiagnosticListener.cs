using System;
using System.Collections.Generic;
using Elastic.Apm.DiagnosticSource;

namespace Elastic.Apm.RabbitMQClient
{
	public class RabbitMQDiagnosticListener : IDiagnosticListener
	{
		private readonly IApmAgent _agent;

		public RabbitMQDiagnosticListener(IApmAgent apmAgent) => _agent = apmAgent;
		public string Name => "RabbitMQ.Net.Client";

		public void OnCompleted() => throw new NotImplementedException();
		public void OnError(Exception error) => throw new NotImplementedException();
		public void OnNext(KeyValuePair<string, object> value) => throw new NotImplementedException();
	}
}
