using System.Collections.Generic;

namespace Singleton
{
    internal class ConfigManager
    {
        private IDictionary<string, object> _settings = new Dictionary<string, object>();

        private static ConfigManager _instance;

        private ConfigManager() {}

        public void Set(string llave, object valor)
        {
            _settings[llave] = valor;
        }

        public object Get(string llave)
        {
            object valor = null;
            if (_settings.ContainsKey(llave))
            {
                valor = _settings[llave];
            }
            return valor;
        }

        public static ConfigManager GetInstance()
        {
            return _instance ?? (_instance = new ConfigManager());
        }
    }
}
