using System;
using CAFU.Core;
using UniRx;

namespace CAFU.Extra.Presenter
{
    public interface ITrigger : IView
    {
        IObservable<Unit> TriggerAsObservable();
    }
}