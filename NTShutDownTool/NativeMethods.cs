using System.Runtime.InteropServices;

public partial class NTShutdownForm
{
    [DllImport("ntdll.dll", SetLastError = true)]
    static extern uint RtlAdjustPrivilege(int Privilege, bool Enable, bool CurrentThread, out bool Enabled);

    [DllImport("ntdll.dll", SetLastError = true)]
    static extern uint NtShutdownSystem(int Action);

    void EjecutarShutdown(int modo)
    {
        bool previo;
        RtlAdjustPrivilege(19, true, false, out previo);
        NtShutdownSystem(modo);
    }
}
