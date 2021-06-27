let { Repository } = require("../solution.js");
let { assert } = require('chai');

describe("Repository", function () {

    describe("constructor", function () {

        it("return current result", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let map = new Map();
            //Initialize the repository
            let repository = new Repository(properties);
            assert.deepEqual(repository.props, properties);
            assert.equal(repository.nextId(), 0);
            assert.equal(repository.data.size, 0);
        });
    });
    describe("count", function () {

        it("return current result", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let map = new Map();
            //Initialize the repository
            let repository = new Repository(properties);

            assert.equal(repository.count, 0);

        });
    });
    describe("add", function () {

        it("throw Error a", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let map = new Map();
            //Initialize the repository
            let repository = new Repository(properties);

            let entity = {
                nammme: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            assert.throws(() => repository.add(entity), `Property name is missing from the entity!`);


        });
        it("throw Errors", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let map = new Map();
            //Initialize the repository
            let repository = new Repository(properties);

            let entity = {
                name: 5,
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            assert.throws(() => repository.add(entity), `Property name is not of correct type!`);


        });
        it("return current result d", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let map = new Map();
            //Initialize the repository
            let repository = new Repository(properties);

            let entity = {
                name: 'string',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            assert.equal(repository.add(entity), 0)
        });
    });
    describe("getId", function () {

        it("return result g", function () {
            module.exports = { Repository };

            // Initialize props object
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            //Initialize the repository
            let repository = new Repository(properties);
            // Add two entities
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repository.add(entity); // Returns 0
            repository.add(entity); // Returns 1
            console.log(repository.getId(0));
            // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
            let obj = repository.getId(0);
            assert.equal(repository.getId(0), obj)

        });
        it("throw k", function () {
            module.exports = { Repository };

            // Initialize props object
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            //Initialize the repository
            let repository = new Repository(properties);
            // Add two entities
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repository.add(entity); // Returns 0
            repository.add(entity); // Returns 1
            console.log(repository.getId(0));
            // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
            assert.throws(() => repository.getId(100), `Entity with id: 100 does not exist!`);


        });
        describe("update k", function () {

            it("return result", function () {

                module.exports = { Repository };

                // Initialize props object
                let properties = {
                    name: "string",
                    age: "number",
                    birthday: "object"
                };
                //Initialize the repository
                let repository = new Repository(properties);
                // Add two entities
                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.add(entity); // Returns 0
                repository.add(entity); // Returns 1
                repository.getId(0);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                repository.getId(1);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                //Update an entity
                entity = {
                    name: 'Gosho',
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.update(1, entity);

                // {"name":"Gosho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}

                let obj = repository.getId(1);
                assert.equal(repository.getId(1), obj)

            });
            it("throw u", function () {

                module.exports = { Repository };

                // Initialize props object
                let properties = {
                    name: "string",
                    age: "number",
                    birthday: "object"
                };
                //Initialize the repository
                let repository = new Repository(properties);
                // Add two entities
                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.add(entity); // Returns 0
                repository.add(entity); // Returns 1
                repository.getId(0);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                repository.getId(1);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                //Update an entity
                entity = {
                    name: 'Gosho',
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                assert.throws(() => repository.update(23, entity), `Entity with id: 23 does not exist!`);

            });
        });
        describe("del e", function () {

            it("return result", function () {

                module.exports = { Repository };

                // Initialize props object
                let properties = {
                    name: "string",
                    age: "number",
                    birthday: "object"
                };
                //Initialize the repository
                let repository = new Repository(properties);
                // Add two entities
                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.add(entity); // Returns 0
                repository.add(entity); // Returns 1
                console.log(repository.getId(0));
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                console.log(repository.getId(1));
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                //Update an entity
                entity = {
                    name: 'Gosho',
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.update(1, entity);
                console.log(repository.getId(1));
                // {"name":"Gosho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                // Delete an entity
                repository.del(0);
                assert.equal(repository.count, 1);



            });
            it("throw q", function () {

                module.exports = { Repository };

                // Initialize props object
                let properties = {
                    name: "string",
                    age: "number",
                    birthday: "object"
                };
                //Initialize the repository
                let repository = new Repository(properties);
                // Add two entities
                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                repository.add(entity); // Returns 0
                repository.add(entity); // Returns 1
                repository.getId(0);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                repository.getId(1);
                // {"name":"Pesho","age":22,"birthday":"1998-01-06T22:00:00.000Z"}
                //Update an entity
                entity = {
                    name: 'Gosho',
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };
                assert.throws(() => repository.del(23), `Entity with id: 23 does not exist!`);

            });
        });

    });
});
