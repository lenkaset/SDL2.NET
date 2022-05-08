﻿using SDL2.NET.HintTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDL2.NET;
public sealed class Hints
{
    internal Hints() { }

    /// <summary>
    /// A hint that specifies whether the Android / iOS built-in accelerometer should be listed as a joystick device, rather than listing actual joysticks only.
    /// </summary>
    /// <remarks>
    /// By default SDL will list real joysticks along with the accelerometer as if it were a 3 axis joystick.
    /// </remarks>
    public AccelerometerAsJoystick AccelerometerAsJoystick { get; } = new();

#warning come back for SDL_RWFromFile
    /// <summary>
    /// A hint that specifies the Android APK expansion file version. <see cref="SDL_HINT_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION" href="https://wiki.libsdl.org/SDL_HINT_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION"/>; <see cref="SDL_HINT_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION" href="https://wiki.libsdl.org/SDL_HINT_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION"/>
    /// </summary>
    /// <remarks>
    /// If both hints were set then SDL_RWFromFile() will look into expansion files after a given relative path was not found in the internal storage and assets. By default this hint is not set and the APK expansion files are not searched.
    /// </remarks>
    public AndroidAPKExpansionFileVersion AndroidAPKExpansionFileVersion { get; } = new();

    /// <summary>
    /// A hint that specifies a variable to control whether mouse and touch events are to be treated together or separately. <see cref="SDL_HINT_ANDROID_SEPARATE_MOUSE_AND_TOUCH" href="https://wiki.libsdl.org/SDL_HINT_ANDROID_SEPARATE_MOUSE_AND_TOUCH"/>
    /// </summary>
    /// <remarks>
    /// The value of this hint is used at runtime, so it can be changed at any time. By default mouse events will be handled as touch events and touch will raise fake mouse events.
    /// </remarks>
    public AndroidSeparateMouseAndTouch AndroidSeparateMouseAndTouch { get; } = new();

    /// <summary>
    /// A hint that specifies whether controllers used with the Apple TV generate UI events. <see cref="SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS" href="https://wiki.libsdl.org/SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS"/>
    /// </summary>
    /// <remarks>
    /// When UI events are generated by controller input, the app will be backgrounded when the Apple TV remote's menu button is pressed, and when the pause or B buttons on gamepads are pressed.
    /// </remarks>
    public AppleTVControllerUIEvents AppleTVControllerUIEvents { get; } = new();

    /// <summary>
    /// A hint that specifies whether the Apple TV remote's joystick axes will automatically match the rotation of the remote. <see cref="SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION" href="https://wiki.libsdl.org/SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION"/>
    /// </summary>
    /// <remarks>
    /// When UI events are generated by controller input, the app will be backgrounded when the Apple TV remote's menu button is pressed, and when the pause or B buttons on gamepads are pressed.
    /// </remarks>
    public AppleTVRemoteAllowRotation AppleTVRemoteAllowRotation { get; } = new();

    /// <summary>
    /// A hint that specifies whether SDL should not use version 4 of the bitmap header when saving BMPs .<see cref="SDL_HINT_BMP_SAVE_LEGACY_FORMAT" href="https://wiki.libsdl.org/SDL_HINT_BMP_SAVE_LEGACY_FORMAT"/>
    /// </summary>
    /// <remarks>
    /// The bitmap header version 4 is required for proper alpha channel support and SDL will use it when required. Should this not be desired, this hint can force the use of the 40 byte header version which is supported everywhere.
    /// </remarks>
    public BMPSaveLegacyFormat BMPSaveLegacyFormat { get; } = new();

    /// <summary>
    /// A hint that specifies if SDL should give back control to the browser automatically when running with asyncify. <see cref="SDL_HINT_EMSCRIPTEN_ASYNCIFY" href="https://wiki.libsdl.org/SDL_HINT_EMSCRIPTEN_ASYNCIFY"/>
    /// </summary>
    /// <remarks>
    /// This hint only applies to the Emscripten platform.
    /// </remarks>
    public EmscriptenAsyncify EmscriptenAsyncify { get; } = new();

    /// <summary>
    /// A hint that specifies a value to override the binding element for keyboard inputs for Emscripten builds.
    /// </summary>
    /// <remarks>
    /// This hint only applies to the Emscripten platform.
    /// </remarks>
    public EmscriptenKeyboardElement EmscriptenKeyboardElement { get; } = new();

    /// <summary>
    /// A hint that specifies how 3D acceleration is used with SDL_GetWindowSurface(). <see cref="SDL_HINT_FRAMEBUFFER_ACCELERATION" href="https://wiki.libsdl.org/SDL_HINT_FRAMEBUFFER_ACCELERATION"/>
    /// </summary>
    /// <remarks>SDL can try to accelerate the screen surface returned by SDL_GetWindowSurface() by using streaming textures with a 3D rendering engine. This variable controls whether and how this is done.</remarks>
    public FramebufferAcceleration FramebufferAcceleration { get; } = new();

    /// <summary>
    /// A hint that specifies scaling quality. <see cref="SDL_HINT_RENDER_SCALE_QUALITY" href="https://wiki.libsdl.org/SDL_HINT_RENDER_SCALE_QUALITY"/>
    /// </summary>
    /// <remarks>This hint is checked when a texture is created and it affects scaling when copying that texture.</remarks>
    public RenderScaleQuality RenderScaleQuality { get; } = new();

    /// <summary>
    /// A hint that specifies whether relative motion is affected by renderer scaling. <see cref="SDL_HINT_MOUSE_RELATIVE_SCALING" href="https://wiki.libsdl.org/SDL_HINT_MOUSE_RELATIVE_SCALING"/>
    /// </summary>
    /// <remarks>
    /// By default relative mouse deltas are affected by DPI and renderer scaling
    /// </remarks>
    public MouseRelativeScaling MouseRelativeScaling { get; } = new();

#warning finish up the rest of the hints
}
