//var gulp = require('gulp'),
//    sass = require('gulp-sass')
//    cssmin = require("gulp-cssmin")
//    rename = require("gulp-rename");

//gulp.task('min:css', function () {
//    return gulp.src('assets/scss/style.scss')
//        .pipe(sass().on('error', sass.logError))
//        .pipe(cssmin())
//        .pipe(rename({
//            suffix: ".min"
//        }))
//        .pipe(gulp.dest('wwwroot/assets/css'));
//    });


var gulp = require('gulp'),
    sass = require('gulp-sass')
cssmin = require("gulp-cssmin")
rename = require("gulp-rename");

var copies = [
    "assets/**/*",
    '!assets/**/scss',
    '!assets/**/scss/**/*',
];

gulp.task('min:css', function (done) {
    gulp.src('assets/scss/style.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(cssmin())
        .pipe(rename({
            suffix: ".min"
        }))
        .pipe(gulp.dest('wwwroot/assets/css'));

    // Copy resources
    gulp.src(copies)
        .pipe(gulp.dest('wwwroot/assets'));

    done();
});

gulp.task('default', gulp.series('min:css'));

