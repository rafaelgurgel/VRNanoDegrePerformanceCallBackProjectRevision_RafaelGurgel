VR Developer Nanodegree - Performance BounceBack Project - Rafael Gurgel

Project done in 10Hours, code rewritten as requested, improvements:

1. All variables removed from update methods.
2. Instead of destroy method, balls get a position reset through an "InvokeRepeating" function.
3. RigidBodies removed from non moving objects.
4. Lighting set to static, lightprobes on dinamic objects.
5. Draw calls reduced from 300 to about 100 through static/dynamic batching.
and all  the other requested alterations.

Frame rate runs stable above 90fps on both gpu and cpu, 