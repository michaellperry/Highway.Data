#region

using System;
using Highway.Data.EventManagement;
using Highway.Data.Interceptors.Events;

#endregion

namespace Highway.Data
{
    /// <summary>
    ///     The interface used to surface events from a context that supports interceptors
    /// </summary>
    public interface IObservableDataContext : IDataContext
    {
        /// <summary>
        ///     The event fired just before the commit of the persistence
        /// </summary>
        event EventHandler<BeforeSave> BeforeSave;

        /// <summary>
        ///     The event fired just after the commit of the persistence
        /// </summary>
        event EventHandler<AfterSave> AfterSaved;
    }
}