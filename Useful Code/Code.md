# Vector(2/3/4) #
Represents the position of a GameObject (2D or 3D)

# Transform #
Provides the position, rotation and scale of a GameObject

# Quaternion #
Represents rotation of an object

# MonoBehaviour Codes #
*Initialization*
- Awake: Occurs only once when the script is called
- OnEnable: Called when the current script has re-enabled or started for the first time
- Start: Called immediately before the first Update()

*Physics*
- FixedUpdate: Occurs at fixed points in time in conjunction with the physics engine
- OnTriggerEnter: Called when a GameObject with a collider crosses a trigger
- OnCollisionEnter: Called when two objects collide with each other
- OnMouseDown: Occurs when the user presses the mouse button over a collider

*Input Events*
- OnMouseUp: Called when the user releases the mouse button
- OnMouseOver: Called when the mouse is over a collider
- OnMouseEnter: Called when the mouse enters a collider
- OnMouseExit: Called when the mouse exits a collider
- OnMouseDrag: Called when the mouse is clicked and held over a collider
- OnMouseUpAsButton: Occurs when a mouse is over a collider and the mouse button is pressed and released

*Game Logic*
- Update: Occurs once per frame and is where general game logic occurs
- LateUpdate: Called after all the calculations have been completed in Update()

*Scene Rendering*
- OnPreCull: Called before the camera determines which GameObjects can be seen
- OnWillRenderObject: Called for each camera that can see a GameObject
- OnBecameVisible: Occurs when a renderer becomes visible to any camera
- OnBecameInvisible: Occurs when a renderer is no longer visible to any camera
- OnPreRender: Called just before the scene is rendered by the camera
- OnPostRender: Called when the camera has finished rendering the scene
- OnRenderObject: Called right after the camera has completed rendering the scene
- OnRenderImage: Called after rendering is complete to create an image

*Pausing, Disabling and Decommissioning*
- OnDissable: Occurs when a component becomes disabled
- OnApplicationQuit: Occurs when the application is about to end
- OnDestroy: Called before the MonoBehaviour is going to be destroyed
