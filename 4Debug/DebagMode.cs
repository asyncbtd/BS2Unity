[System.Flags]
public enum DebugMode {
    None = 0,
    ShowFPS = 1 << 0,      // 0001
    ShowKeyDown = 1 << 1, // 0010
    ShowKey = 1 << 2,    // 0100
    ShowKeyUp = 1 << 3, // 1000
    LogErrors = 1 << 4
}