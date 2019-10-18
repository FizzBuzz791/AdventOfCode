﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoreLinq.Extensions;

namespace Day4
{
    public class Program
    {
        private static readonly string[] Input = {
            "[1518-02-28 00:47] falls asleep","[1518-10-23 23:47] Guard #1627 begins shift","[1518-10-25 00:41] wakes up","[1518-09-13 00:04] Guard #571 begins shift",
            "[1518-05-10 00:10] wakes up","[1518-03-07 00:02] Guard #1901 begins shift","[1518-10-10 00:59] wakes up","[1518-08-21 00:25] falls asleep",
            "[1518-06-18 00:25] falls asleep","[1518-11-19 00:24] falls asleep","[1518-04-13 00:42] wakes up","[1518-11-01 23:51] Guard #1697 begins shift",
            "[1518-05-14 00:14] falls asleep","[1518-08-04 00:49] wakes up","[1518-08-07 00:47] falls asleep","[1518-10-20 00:52] wakes up",
            "[1518-06-17 00:02] Guard #101 begins shift","[1518-04-11 00:56] wakes up","[1518-07-16 00:03] Guard #2593 begins shift","[1518-09-30 00:20] falls asleep",
            "[1518-10-31 00:34] falls asleep","[1518-07-22 00:57] wakes up","[1518-06-19 00:01] Guard #3457 begins shift","[1518-10-13 00:06] falls asleep",
            "[1518-11-13 23:57] Guard #2699 begins shift","[1518-10-07 00:04] Guard #1901 begins shift","[1518-07-09 00:00] Guard #1693 begins shift",
            "[1518-04-09 23:57] Guard #3557 begins shift","[1518-11-11 23:56] Guard #3457 begins shift","[1518-10-28 00:14] wakes up","[1518-06-16 00:14] falls asleep",
            "[1518-04-24 00:46] falls asleep","[1518-06-19 00:44] falls asleep","[1518-09-25 00:11] wakes up","[1518-07-19 00:20] falls asleep",
            "[1518-07-14 23:58] Guard #101 begins shift","[1518-07-28 00:18] falls asleep","[1518-06-03 00:45] falls asleep","[1518-05-23 00:03] Guard #1627 begins shift",
            "[1518-05-10 00:09] falls asleep","[1518-04-28 00:56] falls asleep","[1518-05-22 00:38] wakes up","[1518-04-05 00:03] Guard #1627 begins shift",
            "[1518-03-19 00:00] Guard #1151 begins shift","[1518-06-12 00:56] wakes up","[1518-10-07 00:41] falls asleep","[1518-10-07 00:10] falls asleep",
            "[1518-03-01 00:35] falls asleep","[1518-11-03 00:56] wakes up","[1518-11-14 00:46] falls asleep","[1518-04-10 00:32] falls asleep","[1518-06-25 00:59] wakes up",
            "[1518-05-19 00:41] falls asleep","[1518-08-14 00:52] wakes up","[1518-08-14 00:57] falls asleep","[1518-07-27 23:59] Guard #1693 begins shift",
            "[1518-06-19 00:24] wakes up","[1518-03-11 00:37] falls asleep","[1518-04-20 00:03] falls asleep","[1518-10-20 00:22] falls asleep",
            "[1518-10-09 00:59] wakes up","[1518-02-24 00:08] falls asleep","[1518-07-07 23:58] Guard #1733 begins shift","[1518-05-23 00:59] wakes up",
            "[1518-09-18 00:48] wakes up","[1518-04-27 00:34] wakes up","[1518-03-29 00:29] wakes up","[1518-10-23 00:00] Guard #1697 begins shift",
            "[1518-04-06 00:47] wakes up","[1518-06-18 00:48] wakes up","[1518-08-27 00:38] wakes up","[1518-03-15 00:24] falls asleep","[1518-08-29 00:50] falls asleep",
            "[1518-11-01 00:36] falls asleep","[1518-08-26 00:44] wakes up","[1518-07-21 00:53] wakes up","[1518-06-24 00:50] wakes up","[1518-03-07 00:21] falls asleep",
            "[1518-10-07 00:35] falls asleep","[1518-09-29 00:41] falls asleep","[1518-10-27 00:26] falls asleep","[1518-04-26 00:56] wakes up",
            "[1518-03-28 23:56] Guard #2593 begins shift","[1518-04-07 00:49] wakes up","[1518-02-25 23:49] Guard #3457 begins shift","[1518-03-06 00:56] wakes up",
            "[1518-11-07 00:45] falls asleep","[1518-03-02 00:04] Guard #1693 begins shift","[1518-10-11 00:53] wakes up","[1518-04-21 00:30] falls asleep",
            "[1518-04-26 00:48] falls asleep","[1518-03-15 00:00] Guard #1901 begins shift","[1518-06-09 00:52] wakes up","[1518-05-05 00:05] falls asleep",
            "[1518-09-23 00:57] falls asleep","[1518-10-21 23:56] Guard #1151 begins shift","[1518-11-05 00:56] falls asleep","[1518-10-16 00:18] falls asleep",
            "[1518-09-20 00:49] wakes up","[1518-07-14 00:00] Guard #3559 begins shift","[1518-08-17 00:06] falls asleep","[1518-08-03 00:08] wakes up",
            "[1518-03-25 00:04] Guard #743 begins shift","[1518-03-12 23:59] Guard #2399 begins shift","[1518-04-24 00:43] wakes up","[1518-10-30 00:41] wakes up",
            "[1518-10-19 00:56] wakes up","[1518-03-05 00:36] wakes up","[1518-07-11 00:43] falls asleep","[1518-09-29 00:48] wakes up",
            "[1518-07-10 23:47] Guard #2699 begins shift","[1518-07-05 00:49] wakes up","[1518-06-07 00:51] wakes up","[1518-04-07 00:10] falls asleep",
            "[1518-05-28 00:04] falls asleep","[1518-06-05 00:33] wakes up","[1518-09-06 00:03] Guard #743 begins shift","[1518-06-20 23:48] Guard #571 begins shift",
            "[1518-02-28 00:26] falls asleep","[1518-03-23 23:58] Guard #743 begins shift","[1518-02-22 00:44] wakes up","[1518-06-27 00:28] falls asleep",
            "[1518-06-05 00:23] wakes up","[1518-11-13 00:56] wakes up","[1518-02-16 00:38] wakes up","[1518-11-10 00:23] falls asleep","[1518-11-06 00:48] falls asleep",
            "[1518-02-27 00:04] Guard #443 begins shift","[1518-04-24 00:51] wakes up","[1518-11-21 00:22] falls asleep","[1518-09-30 00:03] Guard #101 begins shift",
            "[1518-09-27 00:35] wakes up","[1518-04-15 00:10] falls asleep","[1518-09-22 00:08] falls asleep","[1518-11-05 23:49] Guard #3301 begins shift",
            "[1518-05-07 23:58] Guard #1697 begins shift","[1518-04-09 00:00] Guard #1627 begins shift","[1518-07-21 23:56] Guard #2459 begins shift",
            "[1518-09-01 00:35] falls asleep","[1518-10-17 00:22] falls asleep","[1518-08-17 00:21] wakes up","[1518-10-02 00:38] falls asleep",
            "[1518-06-03 00:55] wakes up","[1518-05-25 00:43] falls asleep","[1518-09-27 23:59] Guard #2819 begins shift","[1518-08-11 00:34] falls asleep",
            "[1518-04-02 00:15] falls asleep","[1518-07-14 00:39] wakes up","[1518-10-20 00:47] falls asleep","[1518-03-21 00:16] falls asleep",
            "[1518-04-01 00:20] falls asleep","[1518-05-18 00:20] falls asleep","[1518-02-22 00:23] falls asleep","[1518-11-11 00:13] falls asleep",
            "[1518-09-09 00:58] wakes up","[1518-03-05 00:28] falls asleep","[1518-04-20 00:29] wakes up","[1518-03-31 00:00] Guard #2657 begins shift",
            "[1518-06-26 00:32] wakes up","[1518-06-09 00:04] Guard #1627 begins shift","[1518-04-27 00:03] Guard #1151 begins shift",
            "[1518-09-06 23:48] Guard #673 begins shift","[1518-07-26 00:54] wakes up","[1518-05-22 00:22] falls asleep","[1518-10-17 00:56] wakes up",
            "[1518-04-09 00:22] falls asleep","[1518-03-03 00:03] Guard #2399 begins shift","[1518-05-25 00:12] falls asleep",
            "[1518-09-17 00:00] Guard #1693 begins shift","[1518-06-16 00:57] wakes up","[1518-06-11 00:00] Guard #673 begins shift","[1518-07-29 00:49] falls asleep",
            "[1518-10-24 23:56] Guard #743 begins shift","[1518-11-11 00:57] falls asleep","[1518-06-10 00:19] wakes up","[1518-04-01 00:52] wakes up",
            "[1518-10-26 00:17] falls asleep","[1518-09-06 00:36] falls asleep","[1518-08-21 00:47] falls asleep","[1518-08-26 00:49] falls asleep",
            "[1518-10-02 00:28] falls asleep","[1518-10-01 00:32] wakes up","[1518-11-03 00:55] falls asleep","[1518-08-25 00:56] wakes up",
            "[1518-08-21 00:41] wakes up","[1518-06-02 23:56] Guard #2819 begins shift","[1518-08-11 23:56] Guard #1693 begins shift",
            "[1518-05-05 23:57] Guard #443 begins shift","[1518-04-28 00:53] wakes up","[1518-08-26 23:59] Guard #1901 begins shift",
            "[1518-08-30 00:36] falls asleep","[1518-05-13 00:04] Guard #2459 begins shift","[1518-02-17 00:23] falls asleep","[1518-10-23 00:26] falls asleep",
            "[1518-02-20 00:41] wakes up","[1518-07-16 00:10] falls asleep","[1518-07-30 00:00] Guard #3557 begins shift","[1518-11-02 00:20] wakes up",
            "[1518-07-13 00:49] wakes up","[1518-06-30 23:51] Guard #2459 begins shift","[1518-07-16 00:53] wakes up","[1518-04-23 00:21] wakes up",
            "[1518-03-13 00:46] falls asleep","[1518-04-07 00:58] wakes up","[1518-11-08 00:44] falls asleep","[1518-11-09 23:57] Guard #3301 begins shift",
            "[1518-07-02 00:52] wakes up","[1518-08-20 00:59] wakes up","[1518-09-10 00:03] Guard #2819 begins shift","[1518-09-25 00:21] falls asleep",
            "[1518-05-29 00:34] wakes up","[1518-11-08 00:58] wakes up","[1518-10-21 00:02] Guard #2657 begins shift","[1518-06-01 00:00] Guard #2819 begins shift",
            "[1518-09-24 00:29] falls asleep","[1518-04-19 23:48] Guard #3559 begins shift","[1518-08-28 00:14] falls asleep","[1518-06-25 00:56] falls asleep",
            "[1518-05-16 00:56] wakes up","[1518-02-25 00:37] falls asleep","[1518-05-17 00:55] wakes up","[1518-07-24 23:57] Guard #2819 begins shift",
            "[1518-10-03 00:02] Guard #1151 begins shift","[1518-02-26 00:40] falls asleep","[1518-04-07 00:02] Guard #3301 begins shift",
            "[1518-11-17 23:46] Guard #2399 begins shift","[1518-09-05 00:57] wakes up","[1518-10-10 23:54] Guard #1693 begins shift","[1518-10-10 00:56] falls asleep",
            "[1518-09-08 00:21] wakes up","[1518-06-22 00:41] wakes up","[1518-08-15 00:58] wakes up","[1518-05-27 00:20] wakes up",
            "[1518-11-06 23:58] Guard #2459 begins shift","[1518-10-25 00:10] falls asleep","[1518-09-26 00:23] falls asleep","[1518-05-19 00:10] falls asleep",
            "[1518-06-30 00:03] Guard #1901 begins shift","[1518-09-02 00:52] wakes up","[1518-09-23 23:59] Guard #443 begins shift","[1518-07-28 00:21] wakes up",
            "[1518-10-08 00:04] Guard #1901 begins shift","[1518-10-03 00:15] falls asleep","[1518-03-23 00:47] wakes up","[1518-05-27 00:43] falls asleep",
            "[1518-04-04 00:52] wakes up","[1518-10-05 00:56] wakes up","[1518-09-29 00:25] wakes up","[1518-10-20 00:00] Guard #1901 begins shift",
            "[1518-08-08 00:50] falls asleep","[1518-04-18 00:34] wakes up","[1518-06-07 00:34] falls asleep","[1518-04-27 23:58] Guard #1697 begins shift",
            "[1518-11-05 00:11] falls asleep","[1518-02-18 00:55] wakes up","[1518-08-09 00:12] falls asleep","[1518-07-05 00:21] falls asleep",
            "[1518-11-04 23:56] Guard #1697 begins shift","[1518-03-20 00:06] falls asleep","[1518-10-02 00:32] wakes up","[1518-05-15 00:53] wakes up",
            "[1518-11-18 23:58] Guard #443 begins shift","[1518-10-22 00:14] falls asleep","[1518-10-26 00:50] wakes up","[1518-06-06 00:00] Guard #2819 begins shift",
            "[1518-07-01 00:45] falls asleep","[1518-10-01 00:57] wakes up","[1518-08-24 00:02] Guard #3457 begins shift","[1518-11-04 00:50] falls asleep",
            "[1518-05-04 23:51] Guard #443 begins shift","[1518-10-08 00:29] falls asleep","[1518-09-10 23:56] Guard #3301 begins shift",
            "[1518-10-29 23:57] Guard #3559 begins shift","[1518-10-07 00:37] wakes up","[1518-03-19 00:32] wakes up","[1518-05-30 00:26] wakes up",
            "[1518-05-12 00:46] falls asleep","[1518-06-01 00:19] wakes up","[1518-09-13 00:56] wakes up","[1518-10-02 00:56] wakes up",
            "[1518-04-28 23:48] Guard #1627 begins shift","[1518-04-28 00:58] wakes up","[1518-04-19 00:34] wakes up","[1518-09-24 00:49] wakes up",
            "[1518-08-12 00:31] wakes up","[1518-05-24 00:23] falls asleep","[1518-05-01 00:57] wakes up","[1518-09-04 23:56] Guard #1901 begins shift",
            "[1518-04-29 00:54] wakes up","[1518-03-12 00:56] wakes up","[1518-02-25 00:52] wakes up","[1518-05-09 00:48] wakes up","[1518-04-08 00:54] wakes up",
            "[1518-10-15 00:23] wakes up","[1518-09-15 00:52] wakes up","[1518-08-14 00:51] falls asleep","[1518-04-16 00:02] Guard #743 begins shift",
            "[1518-10-18 00:55] wakes up","[1518-05-08 00:42] falls asleep","[1518-02-23 00:53] wakes up","[1518-03-10 00:49] wakes up",
            "[1518-05-09 00:00] Guard #2399 begins shift","[1518-10-19 00:30] wakes up","[1518-11-03 23:58] Guard #2819 begins shift",
            "[1518-09-20 23:58] Guard #3557 begins shift","[1518-06-14 00:56] wakes up","[1518-07-14 00:52] falls asleep","[1518-09-17 00:18] falls asleep",
            "[1518-04-15 00:02] Guard #1693 begins shift","[1518-08-07 00:52] wakes up","[1518-06-27 00:00] Guard #3557 begins shift",
            "[1518-06-28 00:00] Guard #1627 begins shift","[1518-11-23 00:49] falls asleep","[1518-07-20 23:50] Guard #1151 begins shift",
            "[1518-05-25 23:56] Guard #1693 begins shift","[1518-07-06 00:36] wakes up","[1518-03-30 00:03] Guard #3301 begins shift","[1518-09-24 00:58] wakes up",
            "[1518-05-23 00:52] falls asleep","[1518-06-28 00:55] wakes up","[1518-06-12 00:54] falls asleep","[1518-07-22 23:51] Guard #2819 begins shift",
            "[1518-04-03 00:01] Guard #2399 begins shift","[1518-04-26 00:43] wakes up","[1518-07-15 00:13] falls asleep","[1518-05-03 00:48] falls asleep",
            "[1518-03-19 00:27] falls asleep","[1518-06-05 00:09] falls asleep","[1518-10-10 00:08] falls asleep","[1518-05-25 00:03] Guard #743 begins shift",
            "[1518-05-03 00:18] wakes up","[1518-08-19 00:39] wakes up","[1518-09-01 00:00] Guard #1151 begins shift","[1518-02-22 00:03] Guard #3557 begins shift",
            "[1518-08-02 00:40] wakes up","[1518-03-26 00:48] wakes up","[1518-02-26 00:48] falls asleep","[1518-11-15 00:03] Guard #101 begins shift",
            "[1518-10-03 23:57] Guard #2657 begins shift","[1518-09-28 00:48] wakes up","[1518-08-29 00:00] Guard #443 begins shift","[1518-11-12 00:45] wakes up",
            "[1518-05-07 00:40] wakes up","[1518-10-17 00:00] Guard #2819 begins shift","[1518-04-21 00:39] falls asleep","[1518-08-27 00:30] falls asleep",
            "[1518-09-19 00:37] wakes up","[1518-05-13 00:47] wakes up","[1518-04-13 00:01] falls asleep","[1518-04-08 00:14] falls asleep",
            "[1518-08-21 00:02] Guard #101 begins shift","[1518-07-13 00:35] falls asleep","[1518-06-12 00:38] wakes up","[1518-07-01 00:50] wakes up",
            "[1518-07-15 00:37] wakes up","[1518-09-26 00:44] wakes up","[1518-04-03 00:21] falls asleep","[1518-02-26 00:03] falls asleep",
            "[1518-05-06 23:59] Guard #673 begins shift","[1518-09-28 00:33] falls asleep","[1518-09-27 00:27] falls asleep","[1518-04-01 00:36] falls asleep",
            "[1518-07-23 23:59] Guard #101 begins shift","[1518-09-08 00:04] Guard #2399 begins shift","[1518-07-19 23:57] Guard #673 begins shift",
            "[1518-09-15 00:40] falls asleep","[1518-03-14 00:25] falls asleep","[1518-11-06 00:57] wakes up","[1518-04-21 00:03] Guard #443 begins shift",
            "[1518-09-11 00:57] wakes up","[1518-07-08 00:09] falls asleep","[1518-08-17 00:30] wakes up","[1518-08-30 00:55] wakes up",
            "[1518-10-24 00:03] falls asleep","[1518-04-09 00:58] wakes up","[1518-02-16 00:43] falls asleep","[1518-10-06 00:52] wakes up",
            "[1518-04-12 00:59] wakes up","[1518-08-17 00:58] wakes up","[1518-05-14 00:38] wakes up","[1518-09-19 00:55] wakes up","[1518-08-08 00:32] falls asleep",
            "[1518-08-01 00:54] wakes up","[1518-02-21 00:44] falls asleep","[1518-09-27 00:19] wakes up","[1518-07-11 00:31] falls asleep",
            "[1518-06-10 00:27] wakes up","[1518-09-14 00:06] falls asleep","[1518-04-07 23:59] Guard #101 begins shift","[1518-08-07 00:03] Guard #1901 begins shift",
            "[1518-07-25 00:46] wakes up","[1518-09-29 00:03] Guard #673 begins shift","[1518-10-14 00:51] falls asleep","[1518-07-29 00:12] falls asleep",
            "[1518-05-29 00:42] falls asleep","[1518-10-31 00:23] falls asleep","[1518-02-19 00:53] wakes up","[1518-08-13 00:57] wakes up",
            "[1518-06-20 00:16] falls asleep","[1518-03-15 00:39] falls asleep","[1518-06-19 00:53] wakes up","[1518-06-22 00:49] wakes up",
            "[1518-06-13 00:01] Guard #2699 begins shift","[1518-06-12 00:15] falls asleep","[1518-06-23 00:48] wakes up","[1518-07-07 00:59] wakes up",
            "[1518-04-28 00:09] falls asleep","[1518-10-14 00:47] wakes up","[1518-10-20 00:33] wakes up","[1518-08-08 00:54] wakes up",
            "[1518-09-23 00:27] falls asleep","[1518-11-09 00:29] wakes up","[1518-02-27 00:52] wakes up","[1518-05-28 00:59] wakes up",
            "[1518-02-26 00:27] wakes up","[1518-04-22 00:56] wakes up","[1518-02-19 23:47] Guard #1697 begins shift","[1518-11-04 00:46] wakes up",
            "[1518-05-22 00:29] wakes up","[1518-08-04 00:44] falls asleep","[1518-05-11 00:17] wakes up","[1518-02-24 00:17] wakes up","[1518-10-24 00:26] wakes up",
            "[1518-07-23 00:48] wakes up","[1518-04-16 00:47] wakes up","[1518-09-13 23:56] Guard #443 begins shift","[1518-04-08 00:37] falls asleep",
            "[1518-07-10 00:54] wakes up","[1518-08-12 00:41] wakes up","[1518-06-13 00:49] falls asleep","[1518-09-13 00:46] falls asleep",
            "[1518-07-24 00:59] wakes up","[1518-11-21 23:57] Guard #827 begins shift","[1518-10-04 23:58] Guard #443 begins shift",
            "[1518-08-27 00:43] falls asleep","[1518-07-23 00:04] falls asleep","[1518-04-23 00:19] falls asleep","[1518-10-06 00:42] falls asleep",
            "[1518-03-18 00:03] Guard #1733 begins shift","[1518-02-28 00:34] wakes up","[1518-09-08 00:06] falls asleep","[1518-10-28 00:13] falls asleep",
            "[1518-07-22 00:46] falls asleep","[1518-04-11 00:02] Guard #2399 begins shift","[1518-09-18 00:14] falls asleep","[1518-04-21 00:33] wakes up",
            "[1518-07-25 23:57] Guard #443 begins shift","[1518-04-11 23:51] Guard #2459 begins shift","[1518-07-04 00:11] falls asleep",
            "[1518-11-18 00:04] falls asleep","[1518-11-10 23:57] Guard #2399 begins shift","[1518-08-01 00:42] wakes up","[1518-03-23 00:19] falls asleep",
            "[1518-10-09 00:40] wakes up","[1518-08-05 23:58] Guard #3457 begins shift","[1518-05-02 23:51] Guard #1733 begins shift","[1518-11-23 00:42] wakes up",
            "[1518-06-05 00:56] wakes up","[1518-11-11 00:38] wakes up","[1518-08-28 00:56] wakes up","[1518-05-27 00:49] wakes up","[1518-08-21 00:49] wakes up",
            "[1518-05-11 00:03] Guard #101 begins shift","[1518-03-22 00:25] wakes up","[1518-02-24 00:48] falls asleep","[1518-05-15 00:24] falls asleep",
            "[1518-08-22 00:43] wakes up","[1518-02-16 00:45] wakes up","[1518-03-14 00:58] wakes up","[1518-05-06 00:53] falls asleep","[1518-09-25 00:06] falls asleep",
            "[1518-08-15 00:00] falls asleep","[1518-03-21 23:56] Guard #1151 begins shift","[1518-05-07 00:29] falls asleep","[1518-06-17 00:53] wakes up",
            "[1518-08-09 00:46] wakes up","[1518-08-26 00:57] wakes up","[1518-07-01 00:00] falls asleep","[1518-10-19 00:38] wakes up",
            "[1518-02-15 23:58] Guard #3557 begins shift","[1518-06-27 00:44] wakes up","[1518-05-06 00:56] wakes up","[1518-05-24 00:44] wakes up",
            "[1518-05-29 00:01] Guard #1151 begins shift","[1518-09-30 00:35] wakes up","[1518-06-08 00:01] falls asleep","[1518-07-04 23:56] Guard #2699 begins shift",
            "[1518-10-19 00:46] falls asleep","[1518-02-19 00:59] wakes up","[1518-09-25 23:59] Guard #673 begins shift","[1518-08-13 00:40] wakes up",
            "[1518-05-30 23:49] Guard #1627 begins shift","[1518-04-25 00:50] falls asleep","[1518-07-04 00:53] wakes up","[1518-04-07 00:52] falls asleep",
            "[1518-04-12 00:30] wakes up","[1518-06-06 00:45] falls asleep","[1518-06-23 00:01] Guard #443 begins shift","[1518-07-31 00:11] wakes up",
            "[1518-08-24 00:22] falls asleep","[1518-09-22 00:36] wakes up","[1518-10-14 00:46] falls asleep","[1518-06-20 00:41] wakes up",
            "[1518-10-22 00:55] wakes up","[1518-08-19 00:02] Guard #2593 begins shift","[1518-11-02 00:03] falls asleep","[1518-10-31 00:29] wakes up",
            "[1518-05-26 00:46] falls asleep","[1518-05-16 23:59] Guard #3457 begins shift","[1518-07-23 00:40] falls asleep","[1518-11-17 00:45] falls asleep",
            "[1518-05-19 00:00] Guard #673 begins shift","[1518-03-02 00:39] wakes up","[1518-05-10 00:00] Guard #673 begins shift","[1518-02-21 00:52] wakes up",
            "[1518-08-17 23:59] Guard #3301 begins shift","[1518-03-11 00:49] wakes up","[1518-08-28 00:46] falls asleep","[1518-11-15 00:35] falls asleep",
            "[1518-06-21 00:52] wakes up","[1518-06-27 00:35] falls asleep","[1518-10-12 00:24] falls asleep","[1518-08-09 00:02] Guard #743 begins shift",
            "[1518-11-08 00:02] Guard #3457 begins shift","[1518-10-18 00:02] Guard #2593 begins shift","[1518-03-12 00:46] falls asleep",
            "[1518-09-19 00:44] falls asleep","[1518-04-08 00:29] wakes up","[1518-11-23 00:52] wakes up","[1518-09-01 00:30] wakes up",
            "[1518-04-25 00:45] wakes up","[1518-03-17 00:59] wakes up","[1518-04-10 00:07] falls asleep","[1518-05-22 00:48] falls asleep",
            "[1518-07-03 00:58] wakes up","[1518-03-13 23:59] Guard #571 begins shift","[1518-04-30 00:00] Guard #101 begins shift",
            "[1518-04-27 00:45] falls asleep","[1518-08-01 00:45] falls asleep","[1518-06-24 00:07] falls asleep","[1518-03-13 00:58] wakes up",
            "[1518-02-20 00:01] falls asleep","[1518-03-26 00:43] falls asleep","[1518-05-25 00:59] wakes up","[1518-04-25 00:02] Guard #743 begins shift",
            "[1518-07-10 00:40] falls asleep","[1518-06-15 00:46] wakes up","[1518-10-29 00:54] wakes up","[1518-05-08 00:59] wakes up",
            "[1518-08-25 00:43] falls asleep","[1518-06-14 23:49] Guard #571 begins shift","[1518-11-14 00:26] wakes up","[1518-10-10 00:37] falls asleep",
            "[1518-08-02 23:51] Guard #1627 begins shift","[1518-11-01 00:01] Guard #1901 begins shift","[1518-08-07 23:59] Guard #1901 begins shift",
            "[1518-10-06 00:02] Guard #101 begins shift","[1518-08-16 00:56] wakes up","[1518-11-14 00:24] falls asleep","[1518-05-21 00:10] falls asleep",
            "[1518-08-03 23:58] Guard #1901 begins shift","[1518-06-21 23:58] Guard #1627 begins shift","[1518-07-06 23:56] Guard #3457 begins shift",
            "[1518-07-11 00:24] wakes up","[1518-03-18 00:24] wakes up","[1518-07-19 00:00] Guard #743 begins shift","[1518-08-28 00:25] wakes up",
            "[1518-03-09 00:25] falls asleep","[1518-06-02 00:52] wakes up","[1518-09-02 00:08] falls asleep","[1518-09-06 00:52] wakes up",
            "[1518-10-31 00:41] wakes up","[1518-08-18 00:47] falls asleep","[1518-09-29 00:14] falls asleep","[1518-03-23 00:26] wakes up",
            "[1518-05-27 00:11] falls asleep","[1518-03-06 00:50] wakes up","[1518-07-11 00:40] wakes up","[1518-07-06 00:03] Guard #3457 begins shift",
            "[1518-10-12 00:25] wakes up","[1518-07-09 00:10] falls asleep","[1518-02-26 00:55] wakes up","[1518-06-09 23:53] Guard #1627 begins shift",
            "[1518-07-30 23:47] Guard #1733 begins shift","[1518-06-08 00:32] falls asleep","[1518-11-09 00:12] falls asleep","[1518-07-09 00:17] wakes up",
            "[1518-04-15 00:55] wakes up","[1518-03-27 00:03] Guard #1693 begins shift","[1518-05-17 00:31] wakes up","[1518-09-27 00:07] falls asleep",
            "[1518-03-27 00:47] falls asleep","[1518-03-31 23:59] Guard #1693 begins shift","[1518-06-13 00:30] wakes up","[1518-06-26 00:09] falls asleep",
            "[1518-05-19 23:58] Guard #1901 begins shift","[1518-07-29 00:01] Guard #101 begins shift","[1518-04-03 00:56] wakes up","[1518-07-29 00:44] wakes up",
            "[1518-03-18 00:18] falls asleep","[1518-03-10 00:03] Guard #1733 begins shift","[1518-05-28 00:11] wakes up","[1518-08-15 00:49] falls asleep",
            "[1518-05-19 00:21] wakes up","[1518-02-20 23:57] Guard #1901 begins shift","[1518-06-14 00:00] Guard #3457 begins shift",
            "[1518-07-29 00:32] falls asleep","[1518-08-05 00:54] falls asleep","[1518-06-06 00:57] wakes up","[1518-04-20 00:11] wakes up",
            "[1518-04-19 00:21] falls asleep","[1518-11-20 00:03] Guard #2459 begins shift","[1518-04-22 00:04] Guard #673 begins shift",
            "[1518-04-05 00:13] falls asleep","[1518-11-23 00:03] Guard #743 begins shift","[1518-05-19 00:52] wakes up","[1518-04-22 00:47] wakes up",
            "[1518-04-05 00:53] wakes up","[1518-06-08 00:56] wakes up","[1518-11-03 00:01] Guard #3559 begins shift","[1518-04-12 23:49] Guard #2819 begins shift",
            "[1518-05-01 00:00] Guard #1901 begins shift","[1518-03-27 00:58] wakes up","[1518-09-27 00:00] Guard #2593 begins shift",
            "[1518-08-22 23:56] Guard #2593 begins shift","[1518-04-17 00:00] Guard #101 begins shift","[1518-06-30 00:51] wakes up",
            "[1518-02-24 00:03] Guard #1697 begins shift","[1518-10-18 00:32] falls asleep","[1518-06-09 00:35] falls asleep","[1518-11-10 00:32] wakes up",
            "[1518-07-17 23:50] Guard #2399 begins shift","[1518-09-01 00:59] wakes up","[1518-11-09 00:38] falls asleep","[1518-04-18 00:04] falls asleep",
            "[1518-03-07 00:58] wakes up","[1518-03-25 00:15] falls asleep","[1518-11-02 00:53] wakes up","[1518-09-30 00:34] falls asleep",
            "[1518-05-11 00:40] wakes up","[1518-05-31 00:04] falls asleep","[1518-09-20 00:48] falls asleep","[1518-06-01 00:10] falls asleep",
            "[1518-05-01 23:57] Guard #571 begins shift","[1518-03-11 00:00] Guard #1733 begins shift","[1518-05-30 00:18] falls asleep",
            "[1518-09-03 00:50] falls asleep","[1518-09-25 00:47] wakes up","[1518-06-05 00:50] falls asleep","[1518-09-02 00:00] Guard #3457 begins shift",
            "[1518-10-10 00:10] wakes up","[1518-10-12 00:00] Guard #2399 begins shift","[1518-11-09 00:49] wakes up","[1518-09-19 23:57] Guard #571 begins shift",
            "[1518-08-23 00:40] wakes up","[1518-11-13 00:16] falls asleep","[1518-07-04 00:03] Guard #2699 begins shift","[1518-02-28 00:54] wakes up",
            "[1518-04-01 00:31] wakes up","[1518-04-05 00:43] wakes up","[1518-08-31 00:00] Guard #409 begins shift","[1518-08-24 00:52] wakes up",
            "[1518-10-24 00:04] wakes up","[1518-04-17 00:50] wakes up","[1518-08-10 00:03] Guard #2657 begins shift","[1518-08-03 00:20] falls asleep",
            "[1518-03-02 00:13] falls asleep","[1518-07-27 00:48] wakes up","[1518-09-30 23:57] Guard #443 begins shift","[1518-06-15 00:01] falls asleep",
            "[1518-10-23 00:57] falls asleep","[1518-03-03 00:23] falls asleep","[1518-07-02 00:25] falls asleep","[1518-02-26 00:41] wakes up",
            "[1518-09-10 00:41] falls asleep","[1518-03-03 00:39] wakes up","[1518-08-06 00:28] falls asleep","[1518-07-12 00:00] Guard #443 begins shift",
            "[1518-11-11 00:29] wakes up","[1518-07-14 00:53] wakes up","[1518-05-03 00:58] wakes up","[1518-10-14 00:52] wakes up",
            "[1518-04-26 00:00] Guard #1697 begins shift","[1518-06-29 00:59] wakes up","[1518-03-24 00:41] wakes up","[1518-05-30 00:35] falls asleep",
            "[1518-07-06 00:16] falls asleep","[1518-05-20 23:58] Guard #3457 begins shift","[1518-08-05 00:55] wakes up",
            "[1518-04-13 23:57] Guard #1697 begins shift","[1518-09-24 00:55] falls asleep","[1518-04-14 00:27] wakes up",
            "[1518-08-04 23:59] Guard #2399 begins shift","[1518-11-06 00:19] wakes up","[1518-06-13 00:25] falls asleep","[1518-07-31 00:03] falls asleep",
            "[1518-06-07 00:02] Guard #2399 begins shift","[1518-04-22 00:54] falls asleep","[1518-10-19 00:29] falls asleep","[1518-10-23 00:43] wakes up",
            "[1518-05-12 00:00] Guard #443 begins shift","[1518-06-15 00:34] falls asleep","[1518-03-11 00:20] wakes up","[1518-10-11 00:51] falls asleep",
            "[1518-07-07 00:08] falls asleep","[1518-03-09 00:32] wakes up","[1518-07-18 00:43] wakes up","[1518-11-01 00:55] wakes up",
            "[1518-03-15 00:26] wakes up","[1518-04-17 23:48] Guard #443 begins shift","[1518-05-20 00:41] falls asleep","[1518-08-20 00:29] wakes up",
            "[1518-10-19 00:04] Guard #1693 begins shift","[1518-10-15 00:00] Guard #1151 begins shift","[1518-11-20 00:44] falls asleep",
            "[1518-07-31 23:59] Guard #3457 begins shift","[1518-09-21 00:44] wakes up","[1518-04-22 23:53] Guard #1627 begins shift","[1518-10-07 00:58] wakes up",
            "[1518-09-06 00:33] wakes up","[1518-09-10 00:59] wakes up","[1518-06-02 00:01] falls asleep","[1518-06-11 23:59] Guard #3559 begins shift",
            "[1518-05-04 00:16] falls asleep","[1518-08-19 00:16] falls asleep","[1518-08-12 00:40] falls asleep","[1518-09-21 00:33] falls asleep",
            "[1518-03-12 00:38] wakes up","[1518-10-15 00:44] falls asleep","[1518-09-09 00:33] wakes up","[1518-07-24 00:57] falls asleep",
            "[1518-10-15 00:54] wakes up","[1518-11-17 00:50] wakes up","[1518-02-24 00:56] wakes up","[1518-03-25 00:36] wakes up",
            "[1518-05-26 23:57] Guard #2819 begins shift","[1518-05-25 00:29] wakes up","[1518-09-20 00:56] wakes up","[1518-03-04 00:48] falls asleep",
            "[1518-04-27 00:15] falls asleep","[1518-08-28 00:00] Guard #3301 begins shift","[1518-09-08 00:56] wakes up","[1518-10-02 00:04] Guard #1693 begins shift",
            "[1518-04-10 00:20] wakes up","[1518-06-24 23:57] Guard #2819 begins shift","[1518-09-03 00:54] wakes up","[1518-08-14 00:00] Guard #3457 begins shift",
            "[1518-08-16 00:02] Guard #101 begins shift","[1518-06-08 00:28] wakes up","[1518-05-17 00:38] falls asleep","[1518-03-01 00:49] wakes up",
            "[1518-05-21 23:57] Guard #101 begins shift","[1518-11-02 00:51] falls asleep","[1518-07-29 00:58] wakes up","[1518-11-12 23:56] Guard #3457 begins shift",
            "[1518-09-09 00:00] Guard #101 begins shift","[1518-07-10 00:00] Guard #2699 begins shift","[1518-08-07 00:57] wakes up","[1518-07-02 23:57] Guard #571 begins shift",
            "[1518-03-04 00:58] wakes up","[1518-05-15 00:02] Guard #2459 begins shift","[1518-09-09 00:16] falls asleep","[1518-04-23 00:14] wakes up",
            "[1518-08-24 23:58] Guard #571 begins shift","[1518-07-11 00:01] falls asleep","[1518-04-20 00:21] falls asleep","[1518-07-23 00:27] falls asleep",
            "[1518-08-06 00:45] wakes up","[1518-06-14 00:19] falls asleep","[1518-07-31 00:21] falls asleep","[1518-07-08 00:51] falls asleep","[1518-11-04 00:56] wakes up",
            "[1518-06-04 00:50] wakes up","[1518-04-11 00:31] falls asleep","[1518-03-29 00:09] falls asleep","[1518-09-02 23:58] Guard #571 begins shift",
            "[1518-08-23 00:13] wakes up","[1518-05-28 00:51] wakes up","[1518-04-30 00:39] wakes up","[1518-10-08 00:48] wakes up","[1518-02-19 00:03] Guard #2819 begins shift",
            "[1518-04-27 00:58] wakes up","[1518-10-16 00:34] wakes up","[1518-08-14 00:44] wakes up","[1518-10-27 00:50] wakes up","[1518-04-12 00:34] falls asleep",
            "[1518-06-16 00:04] Guard #1697 begins shift","[1518-08-11 00:04] Guard #2593 begins shift","[1518-08-27 00:48] wakes up","[1518-08-15 00:46] wakes up",
            "[1518-05-11 00:15] falls asleep","[1518-11-23 00:41] falls asleep","[1518-04-28 00:14] wakes up","[1518-02-19 00:37] falls asleep","[1518-10-14 00:33] wakes up",
            "[1518-03-21 00:03] Guard #101 begins shift","[1518-06-28 00:44] falls asleep","[1518-08-25 23:56] Guard #2819 begins shift","[1518-06-11 00:24] falls asleep",
            "[1518-09-15 00:00] Guard #1697 begins shift","[1518-08-29 23:59] Guard #3457 begins shift","[1518-10-01 00:08] falls asleep","[1518-04-16 00:21] falls asleep",
            "[1518-05-09 00:22] falls asleep","[1518-03-01 00:00] Guard #1693 begins shift","[1518-09-21 00:27] wakes up","[1518-07-11 00:53] wakes up",
            "[1518-08-16 23:56] Guard #2699 begins shift","[1518-06-14 00:24] wakes up","[1518-03-26 00:24] wakes up","[1518-09-21 00:11] falls asleep",
            "[1518-06-05 00:02] Guard #1697 begins shift","[1518-11-20 23:59] Guard #1627 begins shift","[1518-04-24 00:41] falls asleep",
            "[1518-03-12 00:02] Guard #3559 begins shift","[1518-05-12 00:54] wakes up","[1518-07-02 00:00] Guard #443 begins shift","[1518-08-22 00:20] falls asleep",
            "[1518-05-28 00:46] falls asleep","[1518-06-22 00:46] falls asleep","[1518-04-12 00:01] falls asleep","[1518-07-30 00:29] falls asleep",
            "[1518-10-16 00:00] Guard #2399 begins shift","[1518-08-23 00:09] falls asleep","[1518-08-26 00:39] falls asleep","[1518-08-13 00:43] falls asleep",
            "[1518-02-23 00:02] Guard #2459 begins shift","[1518-10-11 00:00] falls asleep","[1518-10-25 23:57] Guard #101 begins shift","[1518-10-13 00:41] wakes up",
            "[1518-09-23 00:49] wakes up","[1518-03-03 23:58] Guard #2699 begins shift","[1518-03-21 00:52] wakes up","[1518-08-14 00:59] wakes up",
            "[1518-11-14 00:50] wakes up","[1518-05-03 00:05] falls asleep","[1518-06-25 23:56] Guard #743 begins shift","[1518-07-30 00:57] wakes up",
            "[1518-02-17 00:00] Guard #3457 begins shift","[1518-08-16 00:42] falls asleep","[1518-03-04 00:41] wakes up","[1518-07-12 23:57] Guard #1627 begins shift",
            "[1518-02-22 00:42] falls asleep","[1518-06-02 00:46] falls asleep","[1518-03-16 00:04] Guard #1627 begins shift","[1518-04-30 00:19] falls asleep",
            "[1518-03-22 00:18] falls asleep","[1518-06-02 00:13] wakes up","[1518-09-06 00:06] falls asleep","[1518-10-10 00:52] wakes up","[1518-08-18 00:49] wakes up",
            "[1518-02-18 00:05] falls asleep","[1518-07-08 00:21] wakes up","[1518-09-16 00:03] Guard #827 begins shift","[1518-04-17 00:28] falls asleep",
            "[1518-09-09 00:45] falls asleep","[1518-06-14 00:38] falls asleep","[1518-04-22 00:39] falls asleep","[1518-04-28 00:48] falls asleep",
            "[1518-03-16 00:47] wakes up","[1518-11-11 00:32] falls asleep","[1518-06-19 00:10] falls asleep","[1518-10-13 00:00] Guard #2399 begins shift",
            "[1518-10-01 00:53] falls asleep","[1518-04-04 00:05] falls asleep","[1518-07-29 00:21] wakes up","[1518-09-04 00:04] Guard #409 begins shift",
            "[1518-04-23 00:03] falls asleep","[1518-03-24 00:22] falls asleep","[1518-05-02 00:56] falls asleep","[1518-05-18 00:01] Guard #1627 begins shift",
            "[1518-03-28 00:00] Guard #571 begins shift","[1518-07-03 00:42] falls asleep","[1518-10-30 00:17] falls asleep","[1518-05-22 00:55] wakes up",
            "[1518-05-13 23:59] Guard #1901 begins shift","[1518-04-09 00:40] falls asleep","[1518-11-19 00:25] wakes up","[1518-02-27 00:32] falls asleep",
            "[1518-11-11 00:59] wakes up","[1518-10-11 00:17] wakes up","[1518-03-23 00:46] falls asleep","[1518-03-26 00:21] falls asleep",
            "[1518-10-09 00:03] Guard #3559 begins shift","[1518-07-25 00:31] falls asleep","[1518-03-11 00:10] falls asleep","[1518-09-08 00:55] falls asleep",
            "[1518-11-16 00:37] falls asleep","[1518-03-17 00:39] falls asleep","[1518-07-01 00:38] wakes up","[1518-06-17 23:58] Guard #3301 begins shift",
            "[1518-03-30 00:55] wakes up","[1518-08-17 00:46] falls asleep","[1518-07-12 00:44] falls asleep","[1518-04-03 23:48] Guard #2593 begins shift",
            "[1518-08-07 00:56] falls asleep","[1518-09-05 00:11] falls asleep","[1518-02-19 00:56] falls asleep","[1518-02-28 00:04] Guard #2593 begins shift",
            "[1518-08-08 00:36] wakes up","[1518-04-09 00:27] wakes up","[1518-06-13 00:51] wakes up","[1518-06-27 00:30] wakes up","[1518-11-12 00:33] falls asleep",
            "[1518-08-03 00:33] wakes up","[1518-08-19 23:49] Guard #3559 begins shift","[1518-11-05 00:59] wakes up","[1518-05-13 00:35] falls asleep",
            "[1518-11-16 00:00] Guard #443 begins shift","[1518-04-02 00:00] Guard #1627 begins shift","[1518-05-01 00:31] falls asleep","[1518-08-23 00:29] falls asleep",
            "[1518-09-01 00:25] falls asleep","[1518-03-16 00:13] falls asleep","[1518-07-09 00:58] wakes up","[1518-02-23 00:44] falls asleep",
            "[1518-02-17 23:51] Guard #2819 begins shift","[1518-08-14 23:47] Guard #1151 begins shift","[1518-07-14 00:56] falls asleep","[1518-06-15 00:15] wakes up",
            "[1518-06-03 23:50] Guard #1901 begins shift","[1518-03-12 00:32] falls asleep","[1518-06-28 23:56] Guard #743 begins shift",
            "[1518-03-04 23:59] Guard #2593 begins shift","[1518-09-20 00:54] falls asleep","[1518-09-17 23:57] Guard #3457 begins shift","[1518-07-26 00:46] falls asleep",
            "[1518-04-05 00:51] falls asleep","[1518-05-29 00:29] falls asleep","[1518-05-21 00:49] wakes up","[1518-08-11 00:51] wakes up","[1518-05-06 00:47] falls asleep",
            "[1518-08-21 23:59] Guard #2593 begins shift","[1518-09-07 00:04] falls asleep","[1518-10-27 23:59] Guard #2699 begins shift","[1518-07-09 00:25] falls asleep",
            "[1518-10-26 23:59] Guard #1697 begins shift","[1518-10-09 00:53] falls asleep","[1518-06-22 00:34] wakes up","[1518-03-08 00:04] Guard #409 begins shift",
            "[1518-08-13 00:24] falls asleep","[1518-05-23 23:59] Guard #101 begins shift","[1518-09-17 00:46] wakes up","[1518-07-23 00:29] wakes up",
            "[1518-06-23 00:34] falls asleep","[1518-10-29 00:02] Guard #2399 begins shift","[1518-07-26 23:56] Guard #1901 begins shift","[1518-07-17 00:29] falls asleep",
            "[1518-05-20 00:59] wakes up","[1518-04-24 00:03] Guard #1627 begins shift","[1518-06-29 00:40] falls asleep","[1518-04-19 00:01] Guard #2593 begins shift",
            "[1518-03-05 23:59] Guard #2819 begins shift","[1518-07-21 00:00] falls asleep","[1518-07-18 00:03] falls asleep","[1518-03-20 00:32] wakes up",
            "[1518-04-10 00:43] wakes up","[1518-09-24 23:59] Guard #1627 begins shift","[1518-02-16 00:35] falls asleep","[1518-09-22 00:00] Guard #2593 begins shift",
            "[1518-03-26 00:00] Guard #2819 begins shift","[1518-07-20 00:35] falls asleep","[1518-04-25 00:56] wakes up","[1518-10-14 00:19] falls asleep",
            "[1518-10-07 00:23] wakes up","[1518-03-10 00:07] falls asleep","[1518-05-29 00:52] wakes up","[1518-09-23 00:58] wakes up","[1518-06-21 00:01] falls asleep",
            "[1518-06-07 23:51] Guard #1697 begins shift","[1518-05-28 00:55] falls asleep","[1518-10-09 00:33] falls asleep","[1518-10-23 00:59] wakes up",
            "[1518-05-11 00:26] falls asleep","[1518-07-27 00:43] falls asleep","[1518-05-26 00:52] wakes up","[1518-08-02 00:22] falls asleep",
            "[1518-03-23 00:00] Guard #571 begins shift","[1518-07-14 00:59] wakes up","[1518-04-02 00:18] wakes up","[1518-02-22 00:30] wakes up",
            "[1518-10-30 23:56] Guard #673 begins shift","[1518-03-20 00:04] Guard #1693 begins shift","[1518-08-20 00:42] falls asleep",
            "[1518-04-06 00:02] Guard #673 begins shift","[1518-10-19 00:34] falls asleep","[1518-10-24 00:13] falls asleep","[1518-07-14 00:13] falls asleep",
            "[1518-10-14 00:02] Guard #2593 begins shift","[1518-05-06 00:50] wakes up","[1518-07-19 00:54] wakes up","[1518-07-17 00:59] wakes up",
            "[1518-02-25 00:03] Guard #743 begins shift","[1518-09-07 00:35] wakes up","[1518-11-20 00:50] wakes up","[1518-06-05 00:31] falls asleep",
            "[1518-05-15 23:56] Guard #3559 begins shift","[1518-11-04 00:17] falls asleep","[1518-10-10 00:04] Guard #2399 begins shift","[1518-10-29 00:52] falls asleep",
            "[1518-06-01 23:53] Guard #101 begins shift","[1518-07-31 00:35] wakes up","[1518-07-23 00:15] wakes up","[1518-05-29 23:59] Guard #1901 begins shift",
            "[1518-08-12 00:24] falls asleep","[1518-03-17 00:00] Guard #1693 begins shift","[1518-11-16 23:56] Guard #1901 begins shift","[1518-08-01 00:13] falls asleep",
            "[1518-09-18 23:59] Guard #2699 begins shift","[1518-07-08 00:56] wakes up","[1518-03-30 00:18] falls asleep","[1518-10-03 00:48] wakes up",
            "[1518-09-14 00:46] wakes up","[1518-05-04 00:33] wakes up","[1518-11-06 00:03] falls asleep","[1518-06-10 00:25] falls asleep","[1518-08-20 00:02] falls asleep",
            "[1518-06-04 00:04] falls asleep","[1518-05-18 00:26] wakes up","[1518-11-15 00:50] wakes up","[1518-11-07 00:56] wakes up","[1518-06-22 00:39] falls asleep",
            "[1518-09-19 00:31] falls asleep","[1518-03-04 00:16] falls asleep","[1518-05-17 00:29] falls asleep","[1518-03-06 00:55] falls asleep",
            "[1518-10-15 00:14] falls asleep","[1518-08-29 00:57] wakes up","[1518-04-25 00:43] falls asleep","[1518-08-02 00:03] Guard #1697 begins shift",
            "[1518-08-03 00:01] falls asleep","[1518-02-17 00:33] wakes up","[1518-03-15 00:50] wakes up","[1518-06-10 00:04] falls asleep","[1518-05-16 00:27] falls asleep",
            "[1518-05-02 00:58] wakes up","[1518-05-30 00:52] wakes up","[1518-04-26 00:24] falls asleep","[1518-08-14 00:24] falls asleep","[1518-04-14 00:13] falls asleep",
            "[1518-08-17 00:25] falls asleep","[1518-11-16 00:54] wakes up","[1518-11-05 00:29] wakes up","[1518-06-17 00:19] falls asleep",
            "[1518-05-04 00:02] Guard #3557 begins shift","[1518-05-27 23:52] Guard #3457 begins shift","[1518-07-20 00:48] wakes up","[1518-03-28 00:59] wakes up",
            "[1518-06-11 00:25] wakes up","[1518-07-12 00:54] wakes up","[1518-04-21 00:53] wakes up","[1518-09-23 00:04] Guard #1697 begins shift",
            "[1518-03-28 00:36] falls asleep","[1518-09-11 00:41] falls asleep","[1518-06-20 00:02] Guard #1693 begins shift","[1518-08-13 00:01] Guard #1901 begins shift",
            "[1518-05-05 00:55] wakes up","[1518-09-30 00:31] wakes up","[1518-04-06 00:19] falls asleep","[1518-10-05 00:29] falls asleep","[1518-05-31 00:45] wakes up",
            "[1518-04-29 00:04] falls asleep","[1518-03-09 00:01] Guard #1693 begins shift","[1518-07-17 00:02] Guard #1693 begins shift",
            "[1518-06-23 23:56] Guard #2593 begins shift","[1518-06-30 00:46] falls asleep","[1518-11-21 00:50] wakes up","[1518-11-09 00:04] Guard #1697 begins shift",
            "[1518-11-18 00:54] wakes up","[1518-09-12 00:00] Guard #2657 begins shift","[1518-05-22 00:32] falls asleep","[1518-06-22 00:26] falls asleep",
            "[1518-03-06 00:24] falls asleep"};

        public static void Main()
        {
            var activities = Input.ToList();
            activities.Sort();

            var activityRecords = new List<ActivityRecord>();
            while(activities.Count > 0)
            {
                int nextGuard = activities.FindIndex(1, a => a.Contains("Guard"));
                if (nextGuard == -1)
                    nextGuard = activities.Count;
                activityRecords.Add(new ActivityRecord(activities.Take(nextGuard)));
                activities.RemoveRange(0, nextGuard);
            }

            var guardSleepRecords = activityRecords.GroupBy(a => a.GuardId).ToList();
            Part1(guardSleepRecords);
            Part2(guardSleepRecords);
        }

        public static void Part1(IList<IGrouping<int, ActivityRecord>> guardSleepRecords)
        {
            var sleepiestGuard = guardSleepRecords.MaxBy(g => g.ToList().Sum(s => s.TimeAsleep)).FirstOrDefault();
            var maxMinutes = CalculateMaximumSleepMinute(sleepiestGuard);

            Console.WriteLine($"Guard #{sleepiestGuard.Key}: Most asleep at 00:{maxMinutes.Key}.");
        }

        public static void Part2(IList<IGrouping<int, ActivityRecord>> guardSleepRecords)
        {
            var mostAsleep = new Dictionary<int,KeyValuePair<int, int>>();
            foreach (var sleepRecord in guardSleepRecords)
            {
                var maxSleepMinute = CalculateMaximumSleepMinute(sleepRecord);
                mostAsleep.Add(sleepRecord.Key, maxSleepMinute);
            }

            (int guardId, var asleepTime) = mostAsleep.MaxBy(v => v.Value.Value).SingleOrDefault();
            
            Console.WriteLine($"Guard #{guardId}: Most asleep at 00:{asleepTime.Key}.");
        }

        public static KeyValuePair<int, int> CalculateMaximumSleepMinute(IGrouping<int, ActivityRecord> guard)
        {
            var sleepingMinutes = new Dictionary<int, int>();
            foreach (ActivityRecord sleepRecord in guard)
            {
                for (var i = 0; i < 60; i++)
                {
                    for (var j = 0; j < sleepRecord.FallsAsleep.Count; j++)
                    {
                        if (i >= sleepRecord.FallsAsleep[j].Minute && i < sleepRecord.WakesUp[j].Minute)
                        {
                            if (sleepingMinutes.ContainsKey(i))
                                sleepingMinutes[i]++;
                            else
                                sleepingMinutes.Add(i, 1);
                        }
                    }
                }
            }

            var maxBy = sleepingMinutes.MaxBy(m => m.Value);
            return maxBy.FirstOrDefault();
        }
    }

    public class ActivityRecord
    {
        public int GuardId { get; set; }
        public DateTime StartsShift { get; }
        public IList<DateTime> FallsAsleep { get; } = new List<DateTime>();
        public IList<DateTime> WakesUp { get; } = new List<DateTime>();

        public int TimeAsleep
        {
            get
            {
                return FallsAsleep.Select((t, i) => WakesUp[i].Minute - t.Minute).Sum();
            }
        }

        public ActivityRecord(IEnumerable<string> activityRecords)
        {
            foreach (string activityRecord in activityRecords)
            {
                var activityParts = activityRecord.Split(']');
                string timestamp = activityParts[0];
                string information = activityParts[1];

                if (information.Contains("Guard"))
                {
                    GuardId = int.Parse(information.Substring(information.IndexOf('#') + 1, 4));
                    StartsShift = GetTimestamp(timestamp);
                }
                else if (information.Contains("wakes"))
                {
                    WakesUp.Add(GetTimestamp(timestamp));
                }
                else if (information.Contains("falls"))
                {
                    FallsAsleep.Add(GetTimestamp(timestamp));
                }
            }
        }

        private static DateTime GetTimestamp(string timestamp)
        {
            return DateTime.Parse(timestamp.Replace("[", string.Empty).Replace("]", string.Empty));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Guard ID: {GuardId}");
            builder.AppendLine($"Starts Shift: {StartsShift}");
            builder.AppendLine($"Time Asleep: {TimeAsleep}");

            return builder.ToString();
        }
    }
}
