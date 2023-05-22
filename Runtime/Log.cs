namespace Wsh {

    public class Log {

        private static LogLevel m_logLevel = LogLevel.DEBUG;

        private static string ConvertString(object text, params object[] msgs) {
            string message = text.ToString();
            for(int i = 0; i < msgs.Length; i++) {
                message += "    ";
                message += msgs[i].ToString();
            }
            return message;
        }
        
        private static bool CanLog(LogLevel logLevel) {
            return logLevel >= m_logLevel;
        }

        public static void SetLogLevel(LogLevel logLevel) {
            m_logLevel = logLevel;
        }

        public static void Info(object text, params object[] msgs) {
            if(CanLog(LogLevel.INFO)) {
                UnityEngine.Debug.Log(ConvertString(text, msgs));
            }
        }

        public static void Debug(object text, params object[] msgs) {
            if(CanLog(LogLevel.DEBUG)) {
                UnityEngine.Debug.Log(ConvertString(text, msgs));
            }
        }

        public static void Warning(object text, params object[] msgs) {
            if(CanLog(LogLevel.WARNING)) {
                UnityEngine.Debug.LogWarning(ConvertString(text, msgs));
            }
        }

        public static void Error(object text, params object[] msgs) {
            if(CanLog(LogLevel.ERROR)) {
                UnityEngine.Debug.LogError(ConvertString(text, msgs));
            }
        }

    }

    public enum LogLevel {
        DEBUG = 0,
        INFO = 1,
        WARNING = 2,
        ERROR = 3,
    
        NONE = 99,
    }
}