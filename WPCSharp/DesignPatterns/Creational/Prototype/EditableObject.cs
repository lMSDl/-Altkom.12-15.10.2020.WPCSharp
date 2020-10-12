using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class EditableObject<T> : ICloneable where T : class
    {

        private T _editableObject;

        public void StartEdit()
        {
            if (_editableObject != null)
                return;
            _editableObject = (T)Clone();
        }

        public void FinishEdit()
        {
            _editableObject = null;
        }

        public void CancelEdit()
        {
            if (_editableObject == null)
                return;
            Restore(_editableObject);
            FinishEdit();
        }

        protected abstract void Restore(T clone);

        public abstract object Clone();
    }
}
