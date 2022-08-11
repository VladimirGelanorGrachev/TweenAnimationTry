using DG.Tweening;
using UnityEngine;

namespace Tween
{
    public class TweenPlay : MonoBehaviour
    {
        [SerializeField] private MainWindowView _view;


        [ContextMenu(nameof(Play))]
        public void Play()
        {
            Sequence sequence = DOTween.Sequence();            

            sequence.AppendCallback(Play);
            DOTween.Kill(sequence);
        }
    }
}
