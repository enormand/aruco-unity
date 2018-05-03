﻿using UnityEngine;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Cameras.Calibrations
  {
    public abstract class ArucoCameraCalibrationGeneric<T, U> : ArucoCameraCalibration
      where T : ArucoCamera 
      where U : CalibrationFlags
    {
      // Editor fields

      [SerializeField]
      [Tooltip("The camera system to use.")]
      private T arucoCamera;

      [SerializeField]
      [Tooltip("The flags for the cameras calibration.")]
      protected U calibrationFlags;

      // MonoBehaviour methods

      /// <summary>
      /// Sets <see cref="ArucoCameraController.ArucoCamera"/> and <see cref="ArucoCameraCalibration.CalibrationFlags"/>
      /// with editor fields if not nulls.
      /// </summary>
      protected override void Awake()
      {
        base.Awake();
        if (arucoCamera != null)
        {
          ArucoCamera = arucoCamera;
        }
        if (calibrationFlags != null)
        {
          CalibrationFlags = calibrationFlags;
        }
      }
    }
  }

  /// \} aruco_unity_package
}