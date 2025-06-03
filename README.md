# Obstacle Dodge

I'm excited to share **Obstacle Dodge**, my Unity 3D platformer project—a thrilling obstacle-dodging experience that challenges players to navigate through dynamic hazards while maintaining momentum and precision across treacherous platforms.

---

## Gameplay & Mechanics

- **Fluid Movement System:** Responsive WASD/Arrow key controls with smooth, time-based movement that feels natural and precise.
- **Dynamic Obstacle Course:** Navigate through spinning hazards, timed droppers, and triggered projectile systems that test reflexes and timing.
- **Environmental Storytelling:** Each collision changes the world—obstacles turn black when hit, leaving a visual trail of your journey.
- **Progressive Challenge:** Advancing players trigger increasingly complex obstacle patterns as they move deeper into the platform.

---

## Interactive Elements

- **Timed Droppers:** Objects that materialize and fall after precise timing windows, requiring prediction and planning.
- **Spinning Hazards:** Rotating obstacles with customizable rotation speeds on all axes for dynamic navigation challenges.
- **Projectile Triggers:** Environmental switches that launch volleys of homing projectiles when activated by player proximity.
- **Smart Projectiles:** Pursue the player’s position actively, adding intensity and urgency to movement decisions.

---

## Architecture & Design Patterns

- **Component-Based Design:** Modular MonoBehaviour scripts handle movement, collision detection, environmental reactions, and feedback independently.
- **Event-Driven Interactions:** Trigger-based systems provide immediate feedback and dynamic state changes.
- **Configurable Parameters:** Public and serialized fields allow designers to adjust behavior like timing, speed, and difficulty without altering code.
- **State Management:** Objects track interaction states to modify behavior, supporting persistent world interaction.

---

## Performance & Responsiveness

- **Time-Based Movement:** Frame-rate independent motion using `Time.deltaTime`, ensuring smooth control across devices.
- **Efficient Collision Detection:** Tag-based collision filtering ensures only relevant objects affect gameplay state.
- **Optimized Update Loops:** Lightweight and purpose-driven `Update` methods maintain high performance during intensive sequences.

---

## Technical Implementation

- **Player-Centric Design:** All obstacles and environment behaviors are triggered or influenced by player actions.
- **Visual Feedback Systems:** Real-time color changes and material swaps provide immediate feedback upon impact.
- **Scoring & Progress Tracking:** Built-in hit counter system tracks performance and reinforces improvement.
- **Modular Obstacle System:** Each obstacle operates independently, supporting scalable and creative level design.

---

## Reflections

Building **Obstacle Dodge** has been an exploration of precise control, reactive environments, and modular gameplay systems. The project emphasizes clean, readable, and maintainable Unity code practices. It offers a flexible foundation for expanding into more complex level design and player progression systems.

The modular architecture allows rapid prototyping of new obstacles and gameplay mechanics. It showcases how thoughtful Unity architecture combined with responsive gameplay mechanics can deliver a compelling and challenging 3D platforming experience.

# Play Link
https://sayannandi.itch.io/obstacle-dodge

[![Watch the video](https://img.youtube.com/vi/G06tTVnXheY/maxresdefault.jpg)](https://youtu.be/G06tTVnXheY)
### [Gameplay Video](https://youtu.be/G06tTVnXheY)

![Image](https://github.com/user-attachments/assets/030c9974-0697-4391-a6c6-1f5d04804633)

![Image](https://github.com/user-attachments/assets/7a1f0117-f062-497e-b868-d3548f53be5c)
