﻿using AdventOfCode.Year2020.Day4;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2020.Day4
{
    public class DocumentTests
    {
        [TestCase("eyr:1972 cid:100 hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926", false)]
        [TestCase("iyr:2019 hcl:#602927 eyr:1967 hgt:170cm ecl:grn pid:012533040 byr:1946", false)]
        [TestCase("hcl:dab227 iyr:2012 ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277", false)]
        [TestCase("hgt:59cm ecl:zzz eyr:2038 hcl:74454a iyr:2023 pid:3556412378 byr:2007", false)]
        [TestCase("pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980 hcl:#623a2f", true)]
        [TestCase("eyr:2029 ecl:blu cid:129 byr:1989 iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm", true)]
        [TestCase("hcl:#888785 hgt:164cm byr:2001 iyr:2015 cid:88 pid:545766238 ecl:hzl eyr:2022", true)]
        [TestCase("iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719", true)]
        public void FindsPassportWithAdvancedValidation(string document, bool isPassport)
        {
            new Document(document, true).IsPassport.ShouldBe(isPassport);
        }
    }
}