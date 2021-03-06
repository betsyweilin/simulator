/**
 * Copyright (c) 2018 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */


﻿using UnityEngine;

public class DuckiebotPositionResetter : MonoBehaviour
{
    public RobotController RobotController;

    public void ResetDuckiebot()
    {
        RobotController.ResetPosition();
        
        var controller = FindObjectOfType<VehicleInputController>();
        if (controller != null)
        {
        	controller.targetLinVel = 0f;
        	controller.targetAngVel = 0f;
        }
    }
}
