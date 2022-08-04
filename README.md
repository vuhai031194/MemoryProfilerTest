# MemoryProfilerTest
I created the project follow this [tutorial](https://docs.unity3d.com/Packages/com.unity.memoryprofiler@0.1/manual/workflow-memory-leaks.html)
I want to test about how memory manager in Unity. 
Check out feature branch to get 3 cases:
- Normal use case: Load and cache when using in scene
- Static cache: Not to load many time when reload scene but trade off memory
Note: 
- Snapshot sometimes snapped wrong memory infomation, cache from previous player. 
- Tutorial recommended Load TestScene Twice, not sure why
