﻿namespace Firebase.Xamarin.Database.Query
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Firebase.Xamarin.Database.Streaming;

    /// <summary>
    /// The FirebaseQuery interface.
    /// </summary>
    public interface IFirebaseQuery
    {
        /// <summary>
        /// Retrieves items which exist on the location specified by this query instance.
        /// </summary>
        /// <typeparam name="T"> Type of the items. </typeparam>
        /// <returns> Collection of <see cref="FirebaseObject{T}"/>. </returns> 
        Task<IReadOnlyCollection<FirebaseObject<T>>> OnceAsync<T>();

        /// <summary>
        /// Returns current location as an observable which allows to real-time listening to events from the firebase server. 
        /// </summary>
        /// <typeparam name="T"> Type of the items. </typeparam>
        /// <returns> Cold observable of <see cref="FirebaseEvent{T}"/>. </returns>
        IObservable<FirebaseEvent<T>> AsObservable<T>(string elementRoot = "");

        /// <summary>
        /// Builds the actual url of this query.
        /// </summary>
        /// <returns> The <see cref="string"/>. </returns>
        Task<string> BuildUrlAsync();
    }
}
