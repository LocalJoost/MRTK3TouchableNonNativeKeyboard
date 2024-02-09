using System.Threading.Tasks;
using MixedReality.Toolkit.UX.Experimental;
using UnityEngine;

public class DelayedAppear : MonoBehaviour
{
    private async Task Start()
    {
        await Task.Delay(3000);
        NonNativeKeyboard.Instance.Open();
    }
}
