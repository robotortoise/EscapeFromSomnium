using Febucci.UI.Core;
using Naninovel.UI;
using UnityEngine;

namespace Febucci.UI.Naninovel
{
    [RequireComponent(typeof(IRevealableText)), RequireComponent(typeof(TAnimCore)), DisallowMultipleComponent]
    public class TAnim_NaninovelPaster : MonoBehaviour
    {
        TAnimCore tAnim;
        IRevealableText reveal;

        void Awake()
        {
            if (!TryGetComponent(out tAnim))
                Debug.LogError("TAnim_NaninovelPaster: TAnimCore component not found!");
            if (!TryGetComponent(out reveal))
                Debug.LogError("TAnim_NaninovelPaster: IRevealableText component not found!");
        }

        void LateUpdate()
        {
            tAnim.maxVisibleCharacters = Mathf.RoundToInt(reveal.RevealProgress * tAnim.CharactersCount);
        }
    }
}
