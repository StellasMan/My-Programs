using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
	public class TaskCancel : Task
	{
		public TaskCancel(Action<Object> action, CancellationToken cancellationToken)
		: base(action, cancellationToken)
		{
			action(cancellationToken);
		}
	}
}
