using System;
using Unity.MLAgents;
using UnityEngine;

namespace Sweet_And_Salty_Studios.MachineLearning
{
	public class DroneAgent : Agent
	{
        #region VARIABLES
        
        [SerializeField] private KeyCode upForceKey = KeyCode.Space;
        [SerializeField] [Range(0, 60)] private float upForceMultiplier = 10f;
        [SerializeField] [Range(0, 6000)] private float rotateSpeed = 10f;

        private new Rigidbody rigidbody = default;

        [SerializeField] private Transform[] propellers = default;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY FUNCTIONS

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            RotatePropellers();

            if(Input.GetKeyDown(upForceKey))
            {
                rigidbody.AddForce(Vector3.up * upForceMultiplier, ForceMode.Impulse);
            }
        }

        #endregion UNITY FUNCTIONS
        private void RotatePropellers()
        {
            for(var i = 0; i < propellers.Length; i++)
            {
                propellers[i].Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            }
        }

        #region CUSTOM FUNCTIONS

        #endregion CUSTOM FUNCTIONS	
    }
}