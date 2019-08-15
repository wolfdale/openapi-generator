=begin
#OpenAPI Petstore

#This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.1.1-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for Petstore::SpecialModelName
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'SpecialModelName' do
  before do
    # run before each test
    @instance = Petstore::SpecialModelName.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SpecialModelName' do
    it 'should create an instance of SpecialModelName' do
      expect(@instance).to be_instance_of(Petstore::SpecialModelName)
    end
  end
  describe 'test attribute "special_property_name"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end