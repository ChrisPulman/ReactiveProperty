﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Helpers;
using System.Runtime.Serialization;

namespace Sample.ViewModels
{
#pragma warning disable 0618
    public class SerializationViewModel
    {
        // [IgnoreDataMember] ignore serialize
        public ReactiveProperty<bool> IsChecked { get; }
        public ReactiveProperty<int> SelectedIndex { get; }
        [DataMember(Order = 3)] // deserialize order
        public ReactiveProperty<string> Text { get; }
        public ReactiveProperty<int> SliderPosition { get; }
        public ReactiveCollection<long> Items { get; }
        public ReactiveCommand Serialize { get; }
        public ReactiveCommand Deserialize { get; }

        public SerializationViewModel()
        {
            // Observable sequence to ObservableCollection
            Items = Observable.Interval(TimeSpan.FromSeconds(1))
                .Take(30)
                .ToReactiveCollection();
            IsChecked = new ReactiveProperty<bool>();
            SelectedIndex = new ReactiveProperty<int>();
            Text = new ReactiveProperty<string>();
            SliderPosition = new ReactiveProperty<int>();

            var serializedString = new ReactiveProperty<string>(mode: ReactivePropertyMode.RaiseLatestValueOnSubscribe);
            Serialize = serializedString.Select(x => x == null).ToReactiveCommand();
            Deserialize = serializedString.Select(x => x != null).ToReactiveCommand();

            // Click Serialize Button
            Serialize.Subscribe(_ =>
            {
                // Serialize ViewModel's all ReactiveProperty Values.
                // return value is string that Serialize by DataContractSerializer.
                serializedString.Value = SerializeHelper.PackReactivePropertyValue(this); // this = ViewModel
            });

            // Click Deserialize Button
            Deserialize.Subscribe(_ =>
            {
                // Deserialize to target ViewModel.
                // Deseirlization order is same as DataContract.
                // Can control DataMemberAttribute's Order Property.
                // more info see http://msdn.microsoft.com/en-us/library/ms729813.aspx
               SerializeHelper.UnpackReactivePropertyValue(this, serializedString.Value);

                serializedString.Value = null; // push to command canExecute
            });
        }
    }
#pragma warning restore 0618
}