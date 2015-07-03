/**
 * Created by Aleksandra on 7/1/2015.
 */
var Course = (function () {

    function validateTitle(value) {
        var regex = /\s{2,}/;
        if (!value || value.length < 1) {
            return false;

        }
        if (value[0] === ' ' || value[value.length - 1] === ' ') {
            return false

        }
        if (regex.test(value)) {
            return false;
        }
    }


    function isNumber(number) {
        if (number === ' ' || number === '') {
            return false;
        }
        return number == Number(number);
    }

    function checkStudentExist(student) {
        return !this._students.some(function (item) {
            return item.student.id === student.id;
        })
    }

    function Course(title) {

        this.title = title;
        this._presentations = [];
        this._students = [];
        this._nextStudentID = 1;
        this._homeworks = [];
        this._nextPresentationID = 1;
        this._examResults = [];


    }

    Object.defineProperty(Course.prototype, 'title', {
        set: function (value) {
            if (validateTitle(value) === false) {
                throw Error('The title is not correct');
            }
            this._title = value;
        },
        get: function () {
            return this._title;
        }
    });
    Course.prototype.addPresentations = function (presentations) {

        if (presentations instanceof Array) {
            validateTitle.apply(this, presentations);
            for (var i = 0; i < presentations.length; i++) {
                var presentation = presentations[i];
                var presentationObj = {title: presentation, id: this._nextPresentationID++};
                this._presentations.push(presentationObj);
            }
        }
        else {
            validateTitle(presentations);
            var presentationObj = {title: presentations, id: this._nextPresentationID++};
            this._presentations.push(presentationObj);
        }
        return this;
    };
    Course.prototype.addStudent = function (student) {
        if (student instanceof Student) {
            if (checkStudentExist.call(this, student) === false) {
                throw Error('The student already exist in the course');
            }
            var studentCopy = Object.create(student);
            var id = this._nextStudentID++;
            this._students.push({student: studentCopy, courseId: id});
        }
        else
            throw Error('This person is not student');
    }
    Course.prototype.getAllStudents = function () {
        var allStudents = [];
        allStudents = this._students.map(function (item) {
            return item.student;
        });
        return allStudents;
    }
    Course.prototype.submitHomework = function (studentID, homeworkID) {
        var indexOfStudentThatHaveSubmittedThatHomework;
        if (!this._students.some(function (item) {
                return item.student.id === studentID;

            })) {
            throw Error('That student doesn\'t exist');
        }
        if (!this._presentations.some(function (item) {
                return item.id === homeworkID;
            })) {
            throw Error('That presentation doesn\'t exist');
        }
        if (!this._homeworks.some(function (item, index) {
                indexOfStudentThatHaveSubmittedThatHomework = index;
                return item.studentID === studentID && item.homeworkID === homeworkID;
            })) {
            this._homeworks.push({studentID: studentID, homeworkID: homeworkID});

        }


    }
    Course.prototype.pushExamResults = function (results) {
        for (var i = 0; i < results.length; i += 1) {
            var result = results[i];
            if (results.some(function (item, index) {
                    return item.studentID === result.studentID && i !== index;
                })) {
                throw Error('You cannot add two results for one student');
            }
            if (!isNumber(result.Score)) {
                throw Error('The score must be number');
            }
            if (!this._students.some(function (item) {
                    return item.student.courseId === result.studentID;
                })) {
                throw Error('You have invalid student');
            }
            this._examResults.push(result);
        }
        for (var i = 0; i < this._students.length; i += 1) {
            var student = this._students[i];
            if (!results.some(function (item) {
                    return item.StudentID === student.courseId;
                })) {
                this._examResults.push({StudentID: student.courseId, Score: 0});
            }

        }
        return this;

    }
    Course.prototype.getTopStudents = function () {
        var finalResults = [];
        var finalResultStudent;
        var studentExamScore;
        var studentHomeworkScore;

        for (var i = 0; i < this._students.length; i += 1) {
            var countStudentSubmittedHomework = 0;
            var student = this._students[i];
            var studentExam = this._examResults.filter(function (item) {
                return item.StudentID === student.courseId;
            });

            studentExamScore = studentExam[0].Score;
            for (var j = 0; j < this._homeworks.length; j += 1) {
                var homework = this._homeworks[j];
                if (homework.studentID === student.courseId) {
                    countStudentSubmittedHomework++;
                }
            }
            var studentHomeworkScore = countStudentSubmittedHomework / this._presentations.length;
            console.log(studentHomeworkScore);

            finalResults.push({
                student: student.student,
                Score:  (studentExamScore/100)*75 + studentHomeworkScore*25
            });

        }
        var finalResultSorted=finalResults.sort(function (a, b) {
            return b.Score - a.Score
        });
        if (finalResultSorted.length <= 10) {
            return finalResultSorted.slice();
        }
        else
            return finalResultSorted.slice(0, 10);

    }

    return Course;
}());
var Person = (function () {

    function validateName(name, regex) {
        return !regex.test(name);

    }

    function Person(firstname, lastname) {
        this.firstname = firstname;
        this.lastname = lastname;

    }

    Object.defineProperty(Person.prototype, 'firstname', {
        set: function (value) {
            if (value.length < 5 || value.length > 20) {
                throw Error('The firstname must be between 5 and 20 characters');
            }
            var regex = /^[A-Z][a-z]*$/;
            if (validateName(value, regex)) {
                throw Error('The firstname must start with Upper and finish with lowercase letter');
            }
            this._firstname = value;
        },
        get: function () {
            return this._firstname;
        }
    });
    Object.defineProperty(Person.prototype, 'lastname', {
        get: function () {
            return this._lastname;
        },
        set: function (value) {
            if (value.length < 5 || value.length > 20) {
                throw Error('The lastname must be between 5 and 20 characters');
            }
            var regex = /^[A-Z][a-z]*$/;
            if (validateName(value, regex)) {
                throw Error('The lastname must start with Upper and finish with lowercase letter');
            }
            this._lastname = value;

        }
    });

    Object.defineProperty(Person.prototype, 'fullname', {
        get: function () {
            return this.firstname + ' ' + this.lastname;
        },
        set: function (value) {
            var fullname = value = split(' ');
            if (fullname.length != 2) {
                throw Error('The full name content firstname and last name separated with space');

            }
            this.firstname = fullname[0];
            this.lastname = fullname[1];
        }


    });
    Person.prototype.toString = function () {
        return 'I am ' + this.firstname + ' ' + this.lastname;
    }

    return Person;
}());


var Student = (function (parent) {
    var studentId = 1;

    function Student(firstname, lastname, age) {
        parent.call(this, firstname, lastname);
        this.age = age;

        this.id = studentId++;
    }

    Object.defineProperty(Student.prototype, 'age', {
        set: function (value) {
            if (value < 18 || value > 30) {
                throw Error('The student must be more than 18 and less than 30 years old');
            }
            this._age = value;
        },
        get: function () {
            return this._age;
        }
    });
    Student.prototype = Object.create(parent);
    Student.prototype.toString = function () {
        return parent.prototype.toString.call(this) + ' and I am ' + this.age + '  years old';
    }

    return Student;

}(Person));

var person=new Person('Saleketojcheva','Lastnamw');

var course = new Course('OOP Java Script');
var st1 = new Student('Aleksandra', 'Stojcheva', 25);
console.log(person.isPrototypeOf(st1));
var st2 = new Student('Goran', 'Cvetkov', 20);
course.addStudent(st1);
course.addStudent(st2);
course.addPresentations(['FirstPresentation', 'SecondPresentation']);
course.submitHomework(1, 1);
course.submitHomework(2, 1);
course.pushExamResults([{StudentID: 1, Score: 80}]);
console.log(course.getTopStudents());






