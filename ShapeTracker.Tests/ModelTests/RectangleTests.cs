using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class RectangleTests : IDisposable
    {
        public void Dispose()
        {
            Rectangle.ClearAll();
        }

        [TestMethod]
        public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(2, 2);
            Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }
        [TestMethod]
        public void RectangleConstructor_CalculatesAreaOfRectangle_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(2, 2);
            Assert.AreEqual(4, newRectangle.getArea());
        }
        }

    }
