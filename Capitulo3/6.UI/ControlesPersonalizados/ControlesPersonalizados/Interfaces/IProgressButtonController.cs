using System;

namespace ControlesPersonalizados.Interfaces
{
    public interface IProgressButtonController
    {
        event EventHandler Clicked;

        void ProgressButtonClicked();
    }
}
