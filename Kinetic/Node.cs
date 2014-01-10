// Node.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    //http://kineticjs.com/docs/symbols/Kinetic.Node.php
    public class Node
    {
        /// <summary>
        /// Node constructor.
        /// </summary>
        public Node(NodeConfig config)
        {
        }

        public NodeAttributes attrs;
        
        /// <summary>
        /// Clone node.
        /// </summary>
        /// <param name="attrs"></param>
        public void clone(object attrs)
        {
        }

        /// <summary>
        /// Create node with JSON string. De-serializtion does not generate custom shape drawing functions, images, or event handlers (this would make the	serialized object huge). If your app uses custom shapes, images, and event handlers (it probably does), then you need to select the appropriate shapes after loading the stage and set these properties via on(), setDrawFunc(), and setImage() methods
        /// </summary>
        /// <param name="JSON">String</param>
        /// <param name="container">Optional container dom element used only if you're creating a stage node</param>
        /// <returns></returns>
        public static Node create(string JSON, Element container)
        {
            return null;
        }

        /// <summary>
        /// Remove and destroy node
        /// </summary>
        public void Destroy()
        {
        }

        /// <summary>
        /// Synthetically fire an event.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="obj">optional object which can be used to pass parameters</param>
        public void fire(string eventType, Object obj)
        {
        }
        
        /// <summary>
        /// Get absolute opacity
        /// </summary>
        /// <returns></returns>
        public Number getAbsoluteOpacity()
        {
            return -1;
        }

        /// <summary>
        /// Get absolute position relative to the top left corner of the stage container div
        /// </summary>
        /// <returns></returns>
        public Number getAbsolutePosition()
        {
            return -1;
        }

        /// <summary>
        /// Get absolute transform of the node which takes into account its ancestor transforms
        /// </summary>
        /// <returns></returns>
        public Number getAbsoluteTransform()
        {
            return -1;
        }

        /// <summary>
        /// Get absolute z-index which takes into account sibling and ancestor indices
        /// </summary>
        /// <returns></returns>
        public Number getAbsoluteZIndex()
        {
            return -1;
        }

        /// <summary>
        /// Get attrs
        /// </summary>
        /// <returns></returns>
        public object getAttrs()
        {
            return null;
        }
        
        /// <summary>
        /// Get dragBoundFunc
        /// </summary>
        /// <returns></returns>
        public Delegate getDragBoundFunc()
        {
            return null;
        }

        /// <summary>
        /// Get draggable
        /// </summary>
        /// <returns></returns>
        public object getDraggable()
        {
            return null;
        }

        /// <summary>
        /// get flag which enables or disables automatically moving the draggable node to a temporary top layer to improve performance.
        /// </summary>
        /// <returns></returns>
        public object getDragOnTop()
        {
            return null;
        }

        /// <summary>
        /// get height
        /// </summary>
        /// <returns></returns>
        public Number getHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get id
        /// </summary>
        /// <returns></returns>
        public string getId()
        {
            return null;
        }

        /// <summary>
        /// Get layer ancestor
        /// </summary>
        /// <returns></returns>
        public object getLayer()
        {
            return null;
        }

        /// <summary>
        /// Get node level in node tree. Returns an integer.
        /// e.g. Stage level will always be 0. Layers will always be 1. Groups and Shapes will always be >= 2
        /// </summary>
        /// <returns></returns>
        public Number getLevel()
        {
            return -1;
        }

        /// <summary>
        /// Determine if node is listening or not.
        /// </summary>
        /// <returns></returns>
        public object getListening()
        {
            return null;
        }

        /// <summary>
        /// Get name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return null;
        }

        /// <summary>
        /// Get offset
        /// </summary>
        /// <returns></returns>
        public Number getOffset()
        {
            return null;
        }

        /// <summary>
        /// get opacity.
        /// </summary>
        /// <returns></returns>
        public Number getOpacity()
        {
            return -1;
        }

        /// <summary>
        /// Get parent container
        /// </summary>
        /// <returns></returns>
        public Container getParent()
        {
            return null;
        }

        /// <summary>
        /// Get node position relative to parent
        /// </summary>
        /// <returns></returns>
        public Number getPosition()
        {
            return -1;
        }

        /// <summary>
        /// Get rotation in radians
        /// </summary>
        /// <returns></returns>
        public Number getRotation()
        {
            return -1;
        }

        /// <summary>
        /// Get rotation in degrees
        /// </summary>
        /// <returns></returns>
        public Number getRotationDeg()
        {
            return -1;
        }

        /// <summary>
        /// Gt scale
        /// </summary>
        /// <returns></returns>
        public Number getScale()
        {
            return -1;
        }

        /// <summary>
        /// Get size
        /// </summary>
        /// <returns></returns>
        public Custom.Size getSize()
        {
            return null;
        }

        /// <summary>
        /// Get stage ancestor
        /// </summary>
        /// <returns></returns>
        public Stage getStage()
        {
            return null;
        }

        /// <summary>
        /// Get transform of the node
        /// </summary>
        /// <returns></returns>
        public Transform getTransform()
        {
            return null;
        }

        /// <summary>
        /// Determine if node is visible or not.
        /// </summary>
        /// <returns></returns>
        public bool getVisible()
        {
            return false;
        }

        /// <summary>
        /// get width
        /// </summary>
        /// <returns></returns>
        public Number getWidth()
        {
            return -1;
        }

        /// <summary>
        /// get x position
        /// </summary>
        /// <returns></returns>
        public Number getX()
        {
            return -1;
        }

        /// <summary>
        /// get y position
        /// </summary>
        /// <returns></returns>
        public Number getY()
        {
            return -1;
        }

        /// <summary>
        /// Get zIndex relative to the node's siblings who share the same parent
        /// </summary>
        /// <returns></returns>
        public int getZIndex()
        {
            return -1;
        }

        /// <summary>
        /// Hide node.
        /// </summary>
        public void hide()
        {
        }

        /// <summary>
        /// Get draggable.
        /// </summary>
        /// <returns></returns>
        public bool isDraggable()
        {
            return false;
        }

        /// <summary>
        /// Determine if node is currently in drag and drop mode
        /// </summary>
        /// <returns></returns>
        public bool isDragging()
        {
            return false;
        }

        /// <summary>
        /// Alias of getListening()
        /// </summary>
        /// <returns></returns>
        public bool isListening()
        {
            return false;
        }

        /// <summary>
        /// Alias of getVisible()
        /// </summary>
        /// <returns></returns>
        public bool isVisible()
        {
            return false;
        }

        /// <summary>
        /// Move node by an amount relative to its current position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void move(Number x, Number y)
        {
        }

        /// <summary>
        /// Move node down
        /// </summary>
        public void moveDown()
        {
        }

        /// <summary>
        /// Move node to another container
        /// </summary>
        /// <param name="newContainer"></param>
        public void moveTo(Container newContainer)
        {
        }

        /// <summary>
        /// Move node to the bottom of its siblings
        /// </summary>
        public void moveToBottom()
        {
        }

        /// <summary>
        /// Move node to the top of its siblings
        /// </summary>
        public void moveToTop()
        {
        }

        /// <summary>
        /// Move node up
        /// </summary>
        public void moveUp()
        {
        }

        /// <summary>
        /// Remove event bindings from the node.
        /// </summary>
        /// <param name="typesStr"></param>
        public void off(string typesStr)
        {
        }

        /// <summary>
        /// Bind events to the node.
        /// </summary>
        /// <param name="typesStr"></param>
        /// <param name="handler"></param>
        public void on(string typesStr, Delegate handler)
        {
        }

        /// <summary>
        /// Remove child from container, but don't destroy it
        /// </summary>
        public void remove()
        {
        }

        /// <summary>
        /// Rotate node by an amount in radians relative to its current rotation
        /// </summary>
        /// <param name="theta"></param>
        public void rotate(Number theta)
        {
        }

        /// <summary>
        /// Rotate node by an amount in degrees relative to its current rotation
        /// </summary>
        /// <param name="deg"></param>
        public void rotateDeg(Number deg)
        {
        }

        /// <summary>
        /// Set absolute position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setAbsolutePosition(Number x, Number y)
        {
        }

        /// <summary>
        /// Set attrs
        /// </summary>
        /// <param name="?"></param>
        public void setAttrs(object config)
        {
        }

        /// <summary>
        /// Set default attrs.
        /// </summary>
        /// <param name="confic"></param>
        public void setDefaultAttrs(object confic)
        {
        }

        /// <summary>
        /// Set drag bound function.
        /// </summary>
        /// <param name="dragBoundFunc"></param>
        public void setDragBoundFunc(Delegate dragBoundFunc)
        {
        }

        /// <summary>
        /// set draggable
        /// </summary>
        /// <param name="draggable"></param>
        public void setDraggable(object draggable)
        {
        }

        /// <summary>
        /// set flag which enables or disables automatically moving the draggable node to a temporary top layer to improve performance.
        /// </summary>
        /// <param name="dragOnTop"></param>
        public void setDragOnTop(object dragOnTop)
        {
        }
        
        /// <summary>
        /// Set height
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(Number height)
        {
        }

        /// <summary>
        /// Set id
        /// </summary>
        /// <param name="id"></param>
        public void setId(string id)
        {
        }

        /// <summary>
        /// Listen or don't listen to events
        /// </summary>
        /// <param name="listening"></param>
        public void setListening(object listening)
        {
        }

        /// <summary>
        /// Set name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
        }

        /// <summary>
        /// Set offset.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setOffset(Number x, Number y)
        {
        }

        /// <summary>
        /// Set opacity.
        /// </summary>
        /// <param name="opacity"></param>
        public void setOpacity(Number opacity)
        {
        }

        /// <summary>
        /// Set node position relative to parent
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setPosition(Number x, Number y)
        {
        }

        /// <summary>
        /// Set rotation in radians
        /// </summary>
        /// <param name="theta"></param>
        public void setRotation(Number theta)
        {
        }

        /// <summary>
        /// Set rotation in degrees
        /// </summary>
        /// <param name="deg"></param>
        public void setRotationDeg(Number deg)
        {
        }

        /// <summary>
        /// Set scale
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setScale(Number x, Number y)
        {
        }

        /// <summary>
        /// Set size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setSize(Number width, Number height)
        {
        }

        /// <summary>
        /// Set visible
        /// </summary>
        /// <param name="visible"></param>
        public void setVisible(bool visible)
        {
        }

        /// <summary>
        /// Set width
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(Number width)
        {
        }

        /// <summary>
        /// Set x position
        /// </summary>
        /// <param name="x"></param>
        public void setX(Number x)
        {
        }

        /// <summary>
        /// Set y position
        /// </summary>
        /// <param name="y"></param>
        public void setY(Number y)
        {
        }

        /// <summary>
        /// Set zIndex relative to siblings
        /// </summary>
        /// <param name="zIndex"></param>
        public void setZIndex(int zIndex)
        {
        }

        /// <summary>
        /// Show node
        /// </summary>
        public void show()
        {
        }

        /// <summary>
        /// Simulate event with event bubbling
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="evt"></param>
        public void simulate(object eventType, ElementEvent evt)
        {
        }

        /// <summary>
        /// Creates a composite data URL and requires a callback because the composite is generated asynchronously.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public string toDataURL(ToImageConfig config)
        {
            return null;
        }

        /// <summary>
        /// Converts node into an image.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public object toImage(ToImageConfig config)
        {
            return null;
        }

        /// <summary>
        /// Convert Node into a JSON string.
        /// </summary>
        /// <returns></returns>
        public string toJSON()
        {
            return null;
        }

        /// <summary>
        /// Convert Node into an object for serialization.
        /// </summary>
        /// <returns></returns>
        public object toObject()
        {
            return null;
        }

        /// <summary>
        /// transition node to another state.
        /// </summary>
        /// <param name="config"></param>
        public Transition transitionTo(TransitionConfig config)
        {
            return null;
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class NodeConfig
    {
        /// <summary>
        /// Optional
        /// </summary>
        public bool x;

        /// <summary>
        /// Optional
        /// </summary>
        public bool y;

        /// <summary>
        /// Optional
        /// </summary>
        public bool width;

        /// <summary>
        /// Optional
        /// </summary>
        public bool height;

        /// <summary>
        /// Optional
        /// </summary>
        public bool visible;

        /// <summary>
        /// Optional, whether or not the node is listening for events
        /// </summary>
        public bool listening;

        /// <summary>
        /// Optional, unique id
        /// </summary>
        public string id;

        /// <summary>
        /// Optional, non-unique name
        /// </summary>
        public string name;

        /// <summary>
        /// Optional, determines node opacity. Can be any number between 0 and 1
        /// </summary>
        public bool opacity;

        /// <summary>
        /// Optional
        /// </summary>
        public Custom.Vector scale;

        /// <summary>
        /// Optional, rotation in radians
        /// </summary>
        public bool rotation;

        /// <summary>
        /// Optional, rotation in degrees
        /// </summary>
        public bool rotationDeg;

        /// <summary>
        /// Optional, offset from center point and rotation point
        /// </summary>
        public Custom.Vector offset;

        /// <summary>
        /// Optional
        /// </summary>
        public bool draggable;

        /// <summary>
        /// Optional
        /// </summary>
        public Delegate dragBoundFunc;

        public NodeConfig(params object[] nameValuePairs)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ToImageConfig
    {
        /// <summary>
        /// function executed when the composite has completed
        /// </summary>
        public Delegate callback;

        /// <summary>
        /// Optional. Can be "image/png" or "image/jpeg". "image/png" is the default
        /// </summary>
        public string mimeType;

        /// <summary>
        /// Optional. X position of canvas section.
        /// </summary>
        public Number x;

        /// <summary>
        /// Optional. Y position of canvas section.
        /// </summary>
        public Number y;

        /// <summary>
        /// Optional. Width of canvas section.
        /// </summary>
        public Number width;

        /// <summary>
        /// Optional. Height of canvas section.
        /// </summary>
        public Number height;

        /// <summary>
        /// Optional. Jpeg quality. If using an "image/jpeg" mimeType, you can specify the quality from 0 to 1, where 0 is very poor quality and 1 is very high quality
        /// </summary>
        public Number quality;

        public ToImageConfig(params object[] nameValuePairs)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class NodeAttributes
    {
        public Number startScale;
    }
}
