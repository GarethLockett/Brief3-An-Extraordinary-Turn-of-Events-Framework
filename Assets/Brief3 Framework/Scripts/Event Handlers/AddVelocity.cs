using UnityEngine;

/*
    Script: AddVelocity
    Author: Gareth Lockett
    Version: 1.0
    Description:    Add velocity to a target object when AddVelocity() method called.
*/

public class AddVelocity : MonoBehaviour
{
    // Enumerators
    public enum Axis { XAXIS, YAXIS, ZAXIS }

    // Properties
    public Axis axis;                        // Use one of this game objects axis for direction.
    public float amountOfForce = 1f;         // Amount of force that will be applied to the object.

    // Methods
    public void AddVelocityForce( GameObject targetGameObject )
    {
        // Sanity checks.
        if( targetGameObject == null ) { return; }
        Rigidbody rb = targetGameObject.GetComponent<Rigidbody>();
        if( rb == null ) { return; }

        // Get direction of force.
        Vector3 forceDirection = Vector3.zero;
        switch( this.axis )
        {
            case Axis.XAXIS: forceDirection = this.transform.right; break;
            case Axis.YAXIS: forceDirection = this.transform.up; break;
            case Axis.ZAXIS: forceDirection = this.transform.forward; break;
        }

        // Scale the forceDirection byt the amount of force.
        forceDirection *= this.amountOfForce;

        // Apply the force.
        rb.AddForce( forceDirection, ForceMode.VelocityChange );
    }
}
