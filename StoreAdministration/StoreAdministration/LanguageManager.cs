using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAdministration
{
    internal class LanguageManager
    {
        public static event Action LanguageChanged;

        private static string _currentLanguage = "en";

        public static string CurrentLanguage
        {
            get => _currentLanguage;
            set
            {
                if (_currentLanguage != value)
                {
                    _currentLanguage = value;
                    OnLanguageChanged();
                }
            }
        }

        private static void OnLanguageChanged()
        {
            LanguageChanged?.Invoke();
        }
    }
}
