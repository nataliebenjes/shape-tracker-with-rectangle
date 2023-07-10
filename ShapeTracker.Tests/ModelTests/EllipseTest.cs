using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class EllipseTests : IDisposable
    {
        public void Dispose()
        {
            Ellipse.ClearAll();
        }

        [TestMethod]
        public void EllipseConstructor_CreatesInstanceOfEllipse_Ellipse()
        {
            Ellipse newEllipse = new Ellipse(2, 4);
            Assert.AreEqual(typeof(Ellipse), newEllipse.GetType());
        }
        [TestMethod]
        public void EllipseConstructor_CalculatesAreaOfEllipse_Ellipse()
        {
            Ellipse newEllipse = new Ellipse(2, 4);
            Assert.AreEqual(4, newEllipse.getEllipseArea());
        }
        }

    }