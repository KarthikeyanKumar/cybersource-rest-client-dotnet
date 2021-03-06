/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing PaymentInstrumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentInstrumentsApiTests
    {
        private PaymentInstrumentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentInstrumentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentInstrumentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentInstrumentsApi
            //Assert.IsInstanceOfType(typeof(PaymentInstrumentsApi), instance, "instance is a PaymentInstrumentsApi");
        }

        
        /// <summary>
        /// Test TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet
        /// </summary>
        [Test]
        public void TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string tokenId = null;
            //string offset = null;
            //string limit = null;
            //var response = instance.TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet(profileId, tokenId, offset, limit);
            //Assert.IsInstanceOf<TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response> (response, "response is TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response");
        }
        
        /// <summary>
        /// Test TmsV1PaymentinstrumentsPost
        /// </summary>
        [Test]
        public void TmsV1PaymentinstrumentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //Body2 body = null;
            //var response = instance.TmsV1PaymentinstrumentsPost(profileId, body);
            //Assert.IsInstanceOf<TmsV1PaymentinstrumentsPost201Response> (response, "response is TmsV1PaymentinstrumentsPost201Response");
        }
        
        /// <summary>
        /// Test TmsV1PaymentinstrumentsTokenIdDelete
        /// </summary>
        [Test]
        public void TmsV1PaymentinstrumentsTokenIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string tokenId = null;
            //instance.TmsV1PaymentinstrumentsTokenIdDelete(profileId, tokenId);
            
        }
        
        /// <summary>
        /// Test TmsV1PaymentinstrumentsTokenIdGet
        /// </summary>
        [Test]
        public void TmsV1PaymentinstrumentsTokenIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string tokenId = null;
            //var response = instance.TmsV1PaymentinstrumentsTokenIdGet(profileId, tokenId);
            //Assert.IsInstanceOf<TmsV1PaymentinstrumentsGet200Response> (response, "response is TmsV1PaymentinstrumentsGet200Response");
        }
        
        /// <summary>
        /// Test TmsV1PaymentinstrumentsTokenIdPatch
        /// </summary>
        [Test]
        public void TmsV1PaymentinstrumentsTokenIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string tokenId = null;
            //Body3 body = null;
            //var response = instance.TmsV1PaymentinstrumentsTokenIdPatch(profileId, tokenId, body);
            //Assert.IsInstanceOf<TmsV1PaymentinstrumentsGet200Response> (response, "response is TmsV1PaymentinstrumentsGet200Response");
        }
        
    }

}
