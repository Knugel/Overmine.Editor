# Overmine.Editor

## Setup
Requires Unity ``2019.4.9``
The following .dll files must be copied from the ``<your steam apps folder>\UnderMine\UnderMine_Data\Managed\`` directory into the ``Assets\Libraries\`` directory of the project.

* BehaviourDesigner
* BehaviourDesigner.Runtime
* BugSplat.Unity
* Cocuy.Unity
* Colorful.Unity
* DemiLib
* Discord.Unity
* DOTween
* DOTween43
* DOTween46
* DOTweenPro
* FMOD.Unity
* NavMesh.Unity
* ProceduralLightning.Unity
* Rewired.Unity
* Rewired_Core
* Rewired_Windows
* Steamworks.NET
* SuperSplinesPro.Unity
* UnderMine

## Usage
There currently exists no documentation.

For an example project setup look at [Overmine.Example](https://github.com/Knugel/Overmine.Example)

## Exporting
To export the items into an AssetBundle click on ``Overmine/Bundle`` in the Unity toolbar. This will process all found items and create an AssetBundle in the ``Output`` folder of the project.

## Known Issues
* Changing code while the Editor is running can cause large spikes in memory consumption
    + Fixes:
        + Reopen the Editor.
        + If you have to change Editor code do so while it is closed.
* Sometimes the Behaviour Graph does not display Nodes correctly
    + Fixes:
        + Reopen the Editor.
        + Exporting while in this state will produce invalid AssetBundles.
* Creating a parameter throws an Editor exception
    + Fixes:
        + Reopen the Editor.
