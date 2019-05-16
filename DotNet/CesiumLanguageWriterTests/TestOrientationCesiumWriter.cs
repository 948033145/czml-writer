﻿using System;
using System.Collections.Generic;
using CesiumLanguageWriter;
using CesiumLanguageWriter.Advanced;
using NUnit.Framework;

namespace CesiumLanguageWriterTests
{
    [TestFixture]
    public class TestOrientationCesiumWriter : TestCesiumInterpolatablePropertyWriter<OrientationCesiumWriter>
    {
        [Test]
        public void TestCompleteExample()
        {
            var date = new JulianDate(2451545.0);

            const string id = "MyID";
            var availability = new TimeInterval(date, date.AddDays(2.0));

            var interval1 = new TimeInterval(date, date.AddDays(1.0));

            var interval1Position = new Cartesian(1.0, 2.0, 3.0);
            var interval1Orientation = new UnitQuaternion(1, 0, 0, 0);

            var interval2 = new TimeInterval(date.AddDays(1.0), date.AddDays(2.0));

            var interval2SampleDates = new List<JulianDate>
            {
                date.AddDays(1.0),
                date.AddDays(1.5),
                date.AddDays(2.0)
            };

            var interval2SamplePositions = new List<Cartographic>
            {
                Cartographic.Zero,
                new Cartographic(1.0, 0.0, 0.0),
                new Cartographic(0.0, 1.0, 0.0)
            };
            var interval2SampleOrientations = new List<UnitQuaternion>
            {
                UnitQuaternion.Identity,
                new UnitQuaternion(0.0, 1.0, 0.0, 0.0),
                new UnitQuaternion(0.0, 0.0, 1.0, 0.0)
            };

            const CesiumInterpolationAlgorithm orientationInterpolationAlgorithm = CesiumInterpolationAlgorithm.Linear;
            const int orientationInterpolationDegree = 1;

            var outputStream = new CesiumOutputStream(StringWriter)
            {
                PrettyFormatting = true
            };
            var writer = new CesiumStreamWriter();

            using (var packet = writer.OpenPacket(outputStream))
            {
                packet.WriteId(id);
                packet.WriteAvailability(availability);

                using (var positionWriter = packet.OpenPositionProperty())
                using (var intervalListWriter = positionWriter.OpenMultipleIntervals())
                {
                    using (var interval = intervalListWriter.OpenInterval())
                    {
                        interval.WriteInterval(interval1);
                        interval.WriteCartesian(interval1Position);
                    }

                    using (var interval = intervalListWriter.OpenInterval(interval2.Start, interval2.Stop))
                    {
                        interval.WriteCartographicRadians(interval2SampleDates, interval2SamplePositions);
                    }
                }

                using (var orientationWriter = packet.OpenOrientationProperty())
                using (var intervalListWriter = orientationWriter.OpenMultipleIntervals())
                {
                    using (var interval = intervalListWriter.OpenInterval())
                    {
                        interval.WriteInterval(interval1);
                        interval.WriteUnitQuaternion(interval1Orientation);
                    }

                    using (var interval = intervalListWriter.OpenInterval(interval2.Start, interval2.Stop))
                    {
                        interval.WriteInterpolationAlgorithm(orientationInterpolationAlgorithm);
                        interval.WriteInterpolationDegree(orientationInterpolationDegree);

                        interval.WriteUnitQuaternion(interval2SampleDates, interval2SampleOrientations);
                    }
                }
            }

            Console.WriteLine(StringWriter.ToString());
        }

        [Test]
        public void TestDeletePropertyWithStartAndStop()
        {
            var start = new JulianDate(new GregorianDate(2012, 4, 2, 12, 0, 0));
            var stop = start.AddDays(1.0);

            using (Packet)
            {
                Packet.WriteId("id");

                using (var orientation = Packet.OpenOrientationProperty())
                using (var interval = orientation.OpenInterval(start, stop))
                {
                    interval.WriteDelete(true);
                }
            }

            Assert.AreEqual("{\"id\":\"id\",\"orientation\":{\"interval\":\"20120402T12Z/20120403T12Z\",\"delete\":true}}", StringWriter.ToString());
        }

        [Test]
        public void TestDeletePropertyWithNoInterval()
        {
            using (Packet)
            {
                Packet.WriteId("id");

                using (var orientation = Packet.OpenOrientationProperty())
                using (var interval = orientation.OpenInterval())
                {
                    interval.WriteDelete(true);
                }
            }

            Assert.AreEqual("{\"id\":\"id\",\"orientation\":{\"delete\":true}}", StringWriter.ToString());
        }

        protected override CesiumPropertyWriter<OrientationCesiumWriter> CreatePropertyWriter(string propertyName)
        {
            return new OrientationCesiumWriter(propertyName);
        }
    }
}