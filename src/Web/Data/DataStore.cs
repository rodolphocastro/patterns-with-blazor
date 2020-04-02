using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

namespace Web.Data
{
    public class DataStore<T>
    {
        private readonly HashSet<T> _state = new HashSet<T>();
        private readonly ILogger<DataStore<T>> _logger;

        public IReadOnlyCollection<T> Data => _state;

        public DataStore(ILogger<DataStore<T>> logger = null)
        {
            _logger = logger;
        }

        public void Add(T data)
        {
            if (data is null)
            {
                throw new ArgumentNullException(nameof(data), "Data cannot be null");
            }
            _logger?.LogDebug("Adding {@Input} to {@State}", data, _state);
            _state.Add(data);
        }

        public void Remove(T data)
        {
            if (data is null)
            {
                throw new ArgumentNullException(nameof(data), "Data cannot be null");
            }
            _logger?.LogDebug("Removing {@Input} from {@State}", data, _state);
            _state.Remove(data);
        }

        public void AddRange(IEnumerable<T> dataRange)
        {
            if (dataRange is null)
            {
                throw new ArgumentNullException(nameof(dataRange), "Data cannot be null");
            }

            foreach (var data in dataRange)
            {
                Add(data);
            }
        }
    }
}
