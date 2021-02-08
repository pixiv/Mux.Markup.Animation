// Copyright 2019 pixiv Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xamarin.Forms;

namespace Mux.Markup
{
    /// <summary>
    /// An <see cref="Behaviour{T}" /> that represents <see cref="T:UnityEngine.Animator" />.
    /// </summary>
    public class Animator : Behaviour<UnityEngine.Animator>
    {
        /// <summary>Backing store for the <see cref="ApplyRootMotion" /> property.</summary>
        public static readonly BindableProperty ApplyRootMotionProperty = CreateBindableBodyProperty<bool>(
            "ApplyRootMotion",
            typeof(Animator),
            (body, value) => body.applyRootMotion = value,
            false);

        /// <summary>Backing store for the <see cref="Avatar" /> property.</summary>
        public static readonly BindableProperty AvatarProperty = CreateBindableBodyProperty<UnityEngine.Avatar>(
            "Avatar",
            typeof(Animator),
            (body, value) => body.avatar = value,
            null);

        /// <summary>Backing store for the <see cref="CullingMode" /> property.</summary>
        public static readonly BindableProperty CullingModeProperty = CreateBindableBodyProperty<UnityEngine.AnimatorCullingMode>(
            "CullingMode",
            typeof(Animator),
            (body, value) => body.cullingMode = value,
            UnityEngine.AnimatorCullingMode.AlwaysAnimate);

        /// <summary>Backing store for the <see cref="FeetPivotActive" /> property.</summary>
        public static readonly BindableProperty FeetPivotActiveProperty = CreateBindableBodyProperty<float>(
            "FeetPivotActive",
            typeof(Animator),
            (body, value) => body.feetPivotActive = value,
            0f);

        /// <summary>Backing store for the <see cref="FireEvents" /> property.</summary>
        public static readonly BindableProperty FireEventsProperty = CreateBindableBodyProperty<bool>(
            "FireEvents",
            typeof(Animator),
            (body, value) => body.fireEvents = value,
            true);

        /// <summary>Backing store for the <see cref="KeepAnimatorControllerStateOnDisable" /> property.</summary>
        public static readonly BindableProperty KeepAnimatorControllerStateOnDisableProperty = CreateBindableBodyProperty<bool>(
            "KeepAnimatorControllerStateOnDisable",
            typeof(Animator),
            (body, value) => body.keepAnimatorControllerStateOnDisable = value,
            false);

        /// <summary>Backing store for the <see cref="LayersAffectMassCenter" /> property.</summary>
        public static readonly BindableProperty LayersAffectMassCenterProperty = CreateBindableBodyProperty<bool>(
            "LayersAffectMassCenter",
            typeof(Animator),
            (body, value) => body.layersAffectMassCenter = value);

        /// <summary>Backing store for the <see cref="RuntimeAnimatorController" /> property.</summary>
        public static readonly BindableProperty RuntimeAnimatorControllerProperty = CreateBindableBodyProperty<UnityEngine.RuntimeAnimatorController>(
            "RuntimeAnimatorController",
            typeof(Animator),
            (body, value) => body.runtimeAnimatorController = value);

        /// <summary>Backing store for the <see cref="Speed" /> property.</summary>
        public static readonly BindableProperty SpeedProperty = CreateBindableBodyProperty<float>(
            "Speed",
            typeof(Animator),
            (body, value) => body.speed = value,
            1f);

        /// <summary>Backing store for the <see cref="StabilizeFeet" /> property.</summary>
        public static readonly BindableProperty StabilizeFeetProperty = CreateBindableBodyProperty<bool>(
            "StabilizeFeet",
            typeof(Animator),
            (body, value) => body.stabilizeFeet = value,
            false);

        /// <summary>Backing store for the <see cref="UpdateMode" /> property.</summary>
        public static readonly BindableProperty UpdateModeProperty = CreateBindableBodyProperty<UnityEngine.AnimatorUpdateMode>(
            "UpdateMode",
            typeof(Animator),
            (body, value) => body.updateMode = value,
            UnityEngine.AnimatorUpdateMode.Normal);

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.applyRootMotion" />.
        /// </summary>
        public bool ApplyRootMotion
        {
            get
            {
                return (bool)GetValue(ApplyRootMotionProperty);
            }

            set
            {
                SetValue(ApplyRootMotionProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.avatar" />.
        /// </summary>
        public UnityEngine.Avatar Avatar
        {
            get
            {
                return (UnityEngine.Avatar)GetValue(AvatarProperty);
            }

            set
            {
                SetValue(AvatarProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.cullingMode" />.
        /// </summary>
        public UnityEngine.AnimatorCullingMode CullingMode
        {
            get
            {
                return (UnityEngine.AnimatorCullingMode)GetValue(CullingModeProperty);
            }

            set
            {
                SetValue(CullingModeProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.feetPivotActive" />.
        /// </summary>
        public float FeetPivotActive
        {
            get
            {
                return (float)GetValue(FeetPivotActiveProperty);
            }

            set
            {
                SetValue(FeetPivotActiveProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.fireEvents" />.
        /// </summary>
        public bool FireEvents
        {
            get
            {
                return (bool)GetValue(FireEventsProperty);
            }

            set
            {
                SetValue(FireEventsProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.keepAnimatorControllerStateOnDisable" />.
        /// </summary>
        public bool KeepAnimatorControllerStateOnDisable
        {
            get
            {
                return (bool)GetValue(KeepAnimatorControllerStateOnDisableProperty);
            }

            set
            {
                SetValue(KeepAnimatorControllerStateOnDisableProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.layersAffectMassCenter" />.
        /// </summary>
        public bool LayersAffectMassCenter
        {
            get
            {
                return (bool)GetValue(LayersAffectMassCenterProperty);
            }

            set
            {
                SetValue(LayersAffectMassCenterProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.runtimeAnimatorController" />.
        /// </summary>
        public UnityEngine.RuntimeAnimatorController RuntimeAnimatorController
        {
            get
            {
                return (UnityEngine.RuntimeAnimatorController)GetValue(RuntimeAnimatorControllerProperty);
            }

            set
            {
                SetValue(RuntimeAnimatorControllerProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.speed" />.
        /// </summary>
        public float Speed
        {
            get
            {
                return (float)GetValue(SpeedProperty);
            }

            set
            {
                SetValue(SpeedProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.stabilizeFeet" />.
        /// </summary>
        public bool StabilizeFeet
        {
            get
            {
                return (bool)GetValue(StabilizeFeetProperty);
            }

            set
            {
                SetValue(StabilizeFeetProperty, value);
            }
        }

        /// <summary>
        /// A property that represents <see cref="P:UnityEngine.Animator.updateMode" />.
        /// </summary>
        public UnityEngine.AnimatorUpdateMode UpdateMode
        {
            get
            {
                return (UnityEngine.AnimatorUpdateMode)GetValue(UpdateModeProperty);
            }

            set
            {
                SetValue(UpdateModeProperty, value);
            }
        }

        /// <inheritdoc />
        protected override void AwakeInMainThread()
        {
            Body.applyRootMotion = ApplyRootMotion;
            Body.avatar = Avatar;
            Body.cullingMode = CullingMode;
            Body.feetPivotActive = FeetPivotActive;
            Body.fireEvents = FireEvents;
            Body.keepAnimatorControllerStateOnDisable = KeepAnimatorControllerStateOnDisable;
            Body.layersAffectMassCenter = LayersAffectMassCenter;
            Body.runtimeAnimatorController = RuntimeAnimatorController;
            Body.speed = Speed;
            Body.stabilizeFeet = StabilizeFeet;
            Body.updateMode = UpdateMode;

            base.AwakeInMainThread();
        }
    }
}
