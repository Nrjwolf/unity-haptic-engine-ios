#if UNITY_IOS 
using System.Runtime.InteropServices;
#endif

public static class HapticEngine
{
    #if UNITY_IOS && !UNITY_EDITOR
    [DllImport ( "__Internal" )] private static extern void _IOSNotificationFeedbackError ();
    [DllImport ( "__Internal" )] private static extern void _IOSNotificationFeedbackSuccess ();
    [DllImport ( "__Internal" )] private static extern void _IOSNotificationFeedbackWarning ();
    [DllImport ( "__Internal" )] private static extern void _IOSImpactFeedbackLight ();
    [DllImport ( "__Internal" )] private static extern void _IOSImpactFeedbackMedium ();
    [DllImport ( "__Internal" )] private static extern void _IOSImpactFeedbackHeavy ();
    [DllImport ( "__Internal" )] private static extern void _IOSImpactFeedbackSoft (); // IOS +13.0, fallback _IOSImpactFeedbackLight
    [DllImport ( "__Internal" )] private static extern void _IOSImpactFeedbackRigid (); // IOS +13.0, fallback _IOSImpactFeedbackHeavy
    [DllImport ( "__Internal" )] private static extern void _IOSSelectionFeedback (); 
    public static void NotificationFeedbackError () => _IOSNotificationFeedbackError ();
    public static void NotificationFeedbackSuccess () => _IOSNotificationFeedbackSuccess ();
    public static void NotificationFeedbackWarning () => _IOSNotificationFeedbackWarning ();
    public static void ImpactFeedbackLight () => _IOSImpactFeedbackLight ();
    public static void ImpactFeedbackMedium () => _IOSImpactFeedbackMedium ();
    public static void ImpactFeedbackHeavy () => _IOSImpactFeedbackHeavy ();
    public static void ImpactFeedbackSoft () => _IOSImpactFeedbackSoft ();
    public static void ImpactFeedbackRigid () => _IOSImpactFeedbackRigid ();
    public static void SelectionFeedback () => _IOSSelectionFeedback ();
    #endif
}
