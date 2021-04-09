#if UNITY_IOS 
using System.Runtime.InteropServices;
using UnityEngine;
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
#if UNITY_IOS && UNITY_EDITOR
    public static void NotificationFeedbackError() {
        Debug.Log("Played Error Feedback.");
    }
    public static void NotificationFeedbackSuccess()
    {
        Debug.Log("Played Success Feedback.");
    }
    public static void NotificationFeedbackWarning()
    {
        Debug.Log("Played Warning Feedback.");
    }
    public static void ImpactFeedbackLight()
    {
        Debug.Log("Played Light Feedback.");
    }
    public static void ImpactFeedbackMedium()
    {
        Debug.Log("Played Medium Feedback.");
    }
    public static void ImpactFeedbackHeavy()
    {
        Debug.Log("Played Heavy Feedback.");
    }
    public static void ImpactFeedbackSoft()
    {
        Debug.Log("Played Soft Feedback.");
    }
    public static void ImpactFeedbackRigid()
    {
        Debug.Log("Played Rigid Feedback.");
    }
    public static void SelectionFeedback()
    {
        Debug.Log("Played Selection Feedback.");
    }
#endif
}
