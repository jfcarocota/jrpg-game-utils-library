using UnityEngine;

namespace JRPGUtils.InputSystem
{
    public static class InputSystem
    {
        /// <summary>
        /// Returns the direction of the keyboard or gamepad stick.
        /// </summary>
        public static Vector2 Axis{ get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); }

        /// <summary>
        /// Returns the direction of the keyboard or gamepad stick in 1 units.
        /// </summary>
        public static Vector2 AxisNormalized { get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized; }

        /// <summary>
        /// Returns the direction of the keyboard or gamepad stick multiplied by delta time.
        /// </summary>
        public static Vector2 AxisDelta { get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime; }

        /// <summary>
        /// Returns the direction of the keyboard or gamepad stick in 1 units multiplied by delta time.
        /// </summary>
        public static Vector2 AxisDeltaNormalized { get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * Time.deltaTime; }
    }
}
