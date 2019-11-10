# Haptic engine

### Instalation

Copypaste ```Plugins/HapticEngine``` folder

You can check ```HapticEngineExample.scene``` on **IOS 10+** iPhone 6s minimum

``` c#
using UnityEngine;

public class HapticEngineExample : MonoBehaviour
{
    void OnGUI()
    {
#if UNITY_IOS && !UNITY_EDITOR
        GUI.matrix = Matrix4x4.Scale(new Vector3(3.5f, 3.5f, 3.5f));
        if (GUILayout.Button("Error")) HapticEngine.NotificationFeedbackError();
        if (GUILayout.Button("Success")) HapticEngine.NotificationFeedbackSuccess();
        if (GUILayout.Button("Warning")) HapticEngine.NotificationFeedbackWarning();
        if (GUILayout.Button("Light")) HapticEngine.ImpactFeedbackLight();
        if (GUILayout.Button("Medium")) HapticEngine.ImpactFeedbackMedium();
        if (GUILayout.Button("Heavy")) HapticEngine.ImpactFeedbackHeavy();
        if (GUILayout.Button("Soft")) HapticEngine.ImpactFeedbackSoft();
        if (GUILayout.Button("Rigid")) HapticEngine.ImpactFeedbackRigid();
        if (GUILayout.Button("Selection")) HapticEngine.SelectionFeedback();
#endif
    }
}
```
