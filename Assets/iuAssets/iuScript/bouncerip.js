#pragma strict

var Bouncibility:float = 1.1;

 

function OnCollisionEnter (collision : Collision) 

{

    rigidbody.velocity.y = collision.relativeVelocity.y/Bouncibility;

}